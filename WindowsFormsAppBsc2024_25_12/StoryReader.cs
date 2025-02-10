using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Data.SQLite;

namespace Story_Reader
{
    public partial class StoryReader : Form
    {
        // Δημιουργία HttpClient και SpeechSynthesizer
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        HttpClient client = new HttpClient();
        // Λίστα για να κρατάει τις ιστορίες
        List<Story> stories = new List<Story>();

        public StoryReader()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            richTextBoxStory.ReadOnly = true;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVoices.DropDownStyle = ComboBoxStyle.DropDownList;

            synthesizer.Volume = 50;
            synthesizer.Rate = 0;

            labelVolumeValue.Text = $"Volume: {trackBarVolume.Value}";
            labelRateValue.Text = $"Speed: {trackBarRate.Value - 3:F2}"; // F2: Μετατροπή σε δεκαδικό αριθμό 

            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                comboBoxVoices.Items.Add(voice.VoiceInfo.Name);
            }

            if (comboBoxVoices.Items.Count > 0)
                comboBoxVoices.SelectedIndex = 0; // Επιλογή προεπιλεγμένης φωνής

            comboBoxCategory.Items.Add("All");
            comboBoxCategory.Items.Add("General");
            comboBoxCategory.Items.Add("Adults");
            comboBoxCategory.Items.Add("In nature");
            comboBoxCategory.Items.Add("About powerful animals");
            comboBoxCategory.Items.Add("Science-Finction");
            comboBoxCategory.SelectedIndex = 0; // Προεπιλογή

            if (!File.Exists("stories.sqlite"))
            {
                CreateDB();
                SaveStoriesToDatabase();
            } else
            {
                LoadStoriesFromDatabase();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (listBoxStories.SelectedItem != null)
            {
                synthesizer.SpeakAsync(richTextBoxStory.Text);
            }
            else
            {
                MessageBox.Show("Please choose a story to listen to.");
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            synthesizer.Volume = trackBarVolume.Value;
            labelVolumeValue.Text = $"Volume: {trackBarVolume.Value}"; // Ενημέρωση label για το Volume

            // Λειτουργία ώστε εάν ο χρήστης αυξομειώσει την ένταση του ήχου, να ξεκινήσει η ιστορία από την αρχή με τα νέα δεδομένα
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                RestartSpeech();
            }
        }

        private void trackBarRate_Scroll(object sender, EventArgs e)
        {
            double rateValue = trackBarRate.Value * 0.25; // Πράξεις για την ορθή λειτουργία του Speed
            synthesizer.Rate = (int)((rateValue - 1.0) * 10);

            labelRateValue.Text = $"Speed: {rateValue:F2}";

            // Λειτουργία ώστε εάν ο χρήστης αυξομειώσει την ταχύτητα της ομιλίας, να ξεκινήσει η ιστορία από την αρχή με τα νέα δεδομένα
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                RestartSpeech();
            }
        }

        private void btnLoadStories_Click(object sender, EventArgs e)
        {
            WipeDB();
            SaveStoriesToDatabase();
        }

        // Όταν επιλεγεί μια ιστορία, εμφάνιση και ανάγνωση της
        private void listBoxStories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStories.SelectedIndex >= 0)
            {
                // Επιλογή συγκεκριμένης ιστορίας
                var selectedStory = stories[listBoxStories.SelectedIndex];

                // Εμφάνιση περιεχομένου στο RichTextBox
                richTextBoxStory.Text = $"Author: {selectedStory.Author}\n\n{selectedStory.Content}";

                // Έλεγχος αν το περιεχόμενο είναι κενό πριν την χρήση synthisizer
                if (!string.IsNullOrEmpty(selectedStory.Content))
                {
                    synthesizer.SpeakAsync(selectedStory.Content);
                }
                else
                {
                    MessageBox.Show("The selected story has no content and is not possible to listen :(", "No Content", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                synthesizer.Pause();
                btnPauseResume.Text = "Resume";
            }
            else if (synthesizer.State == SynthesizerState.Paused)
            {
                synthesizer.Resume();
                btnPauseResume.Text = "Pause";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsyncCancelAll();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxCategory.SelectedItem.ToString();

            listBoxStories.Items.Clear();

            foreach (var story in stories)
            {
                if (selectedCategory == "All" || story.Category == selectedCategory)
                {
                    listBoxStories.Items.Add($"{story.Title} ({story.Category})");
                }
            }
        }

        private void RestartSpeech()
        {
            synthesizer.SpeakAsyncCancelAll(); // Παύση ανάγνωσης συγκεκριμένης ιστορίας

            if (!string.IsNullOrEmpty(richTextBoxStory.Text))
            {
                synthesizer.SpeakAsync(richTextBoxStory.Text); // Επανεκκίνηση ομιλίας με τα νέα δεδομένα
            }
        }

       private void WipeDB()
        {
            SQLiteConnection dbConnection;
            string SQLString;
            SQLiteCommand command;

            dbConnection = new SQLiteConnection("Data Source=stories.sqlite;Version=3;");
            dbConnection.Open();
            SQLString = "drop table Stories";
            command = new SQLiteCommand(SQLString, dbConnection);
            command.ExecuteNonQuery();
            dbConnection.Close();
        }
       private void CreateDB()
        {
            // Δημιουργία DataBase 

            SQLiteConnection dbConnection;
            string SQLString;
            SQLiteCommand command;

            SQLiteConnection.CreateFile("stories.sqlite");
            dbConnection = new SQLiteConnection("Data Source=stories.sqlite;Version=3;");
            dbConnection.Open();
            SQLString = "create table Stories (Title varchar(20), Author string, Content varchar(20), Category varchar(20))";
            command = new SQLiteCommand(SQLString, dbConnection);
            command.ExecuteNonQuery();
            dbConnection.Close();
        }

        private async void SaveStoriesToDatabase()
        {
            MessageBox.Show("No stories found, downloading");
            //try
            {
                SQLiteConnection dbConnection;
                SQLiteCommand command;

                // Λήψη δεδομένων JSON από το API

                string response = await client.GetStringAsync("https://shortstories-api.onrender.com/stories");
                Console.WriteLine(response);

                // Deserialize το JSON στην λίστα με αντικείμενα Story
                var storyList = JsonConvert.DeserializeObject<List<Story>>(response);

                listBoxStories.Items.Clear();  // Καθαρισμός προηγούμενων αντικειμένων
                stories.Clear();

                // Προσθήκη τίτλων των ιστοριών στο ListBox
                foreach (var story in storyList)
                {
                    if (string.IsNullOrEmpty(story.Category)) // Έλεγχος αν το API δεν παρέχει τα σωστά δεδομένα
                    {
                        // Εκχώρηση κατηγορίας με βάση λέξεις-κλειδιά που βρίσκονται στο περιεχόμενο της κάθε ιστορίας
                        if (story.Content.ToLower().Contains("monster") || story.Content.ToLower().Contains("beast")) story.Category = "Science-Finction";
                        else if (story.Content.ToLower().Contains("wolf") || story.Content.ToLower().Contains("wolves")
                            || story.Content.ToLower().Contains("lion")
                            || story.Content.ToLower().Contains("dog")
                            || story.Content.ToLower().Contains("tiger")) story.Category = "About powerful animals";
                        else if (story.Content.ToLower().Contains("tree") || story.Content.ToLower().Contains("forest")
                            || story.Content.ToLower().Contains("mountain")
                            || story.Content.ToLower().Contains("river")
                            || story.Content.ToLower().Contains("lake")) story.Category = "In nature";
                        else if (story.Content.ToLower().Contains("dead") || story.Content.ToLower().Contains("death")
                            || story.Content.ToLower().Contains("die")
                            || story.Content.ToLower().Contains("kill")
                            || story.Content.ToLower().Contains("slay")) story.Category = "Adults";
                        else story.Category = "General";
                    }

                    listBoxStories.Items.Add($"{story.Title} ({story.Category})");
                    stories.Add(story);

                    // Αποθήκευση στο DataBase
                    dbConnection = new SQLiteConnection("Data Source=stories.sqlite;Version=3;");
                    dbConnection.Open();
                    
                    command = new SQLiteCommand(dbConnection);
                    command.CommandText = "insert into Stories (Title, Author, Content, Category) values (@Title, @Author, @Content, @Category)";
                    command.Parameters.AddWithValue("@Title", story.Title);
                    command.Parameters.AddWithValue("@Author", story.Author);
                    command.Parameters.AddWithValue("@Content", story.Content);
                    command.Parameters.AddWithValue("@Category", story.Category); 
                    command.ExecuteNonQuery();
                    dbConnection.Close();

                }

                // Αποθήκευση ιστοριών για μελλοντική χρήση
                stories = storyList;
            }
        }
        private void LoadStoriesFromDatabase()
        {
            stories.Clear();
            listBoxStories.Items.Clear();

            SQLiteConnection dbConnection;
            string SQLString;
            SQLiteCommand command;

            dbConnection = new SQLiteConnection("Data Source=stories.sqlite;Version=3;");
            dbConnection.Open();
            SQLString = "select * from Stories";
            command = new SQLiteCommand(SQLString, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Story story = new Story
                {
                    Title = reader["Title"].ToString(),
                    Author = reader["Author"].ToString(),
                    Content = reader["Content"].ToString(),
                    Category = reader["Category"].ToString()
                };

                stories.Add(story);
                listBoxStories.Items.Add(story.Title);
            }
            dbConnection.Close();
        }
    }


}
