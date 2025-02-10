namespace Story_Reader
{
    partial class StoryReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxStory = new System.Windows.Forms.RichTextBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnLoadStories = new System.Windows.Forms.Button();
            this.listBoxStories = new System.Windows.Forms.ListBox();
            this.trackBarRate = new System.Windows.Forms.TrackBar();
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVolumeValue = new System.Windows.Forms.Label();
            this.labelRateValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxVoices = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRate)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxStory
            // 
            this.richTextBoxStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxStory.Location = new System.Drawing.Point(441, 139);
            this.richTextBoxStory.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxStory.Name = "richTextBoxStory";
            this.richTextBoxStory.Size = new System.Drawing.Size(511, 260);
            this.richTextBoxStory.TabIndex = 2;
            this.richTextBoxStory.Text = "";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(2, 611);
            this.trackBarVolume.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(352, 45);
            this.trackBarVolume.TabIndex = 5;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnRead.Location = new System.Drawing.Point(453, 415);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(148, 40);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Listen story";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnLoadStories
            // 
            this.btnLoadStories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnLoadStories.Location = new System.Drawing.Point(28, 404);
            this.btnLoadStories.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadStories.Name = "btnLoadStories";
            this.btnLoadStories.Size = new System.Drawing.Size(256, 40);
            this.btnLoadStories.TabIndex = 7;
            this.btnLoadStories.Text = "Refresh available stories";
            this.btnLoadStories.UseVisualStyleBackColor = true;
            this.btnLoadStories.Click += new System.EventHandler(this.btnLoadStories_Click);
            // 
            // listBoxStories
            // 
            this.listBoxStories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listBoxStories.FormattingEnabled = true;
            this.listBoxStories.ItemHeight = 16;
            this.listBoxStories.Location = new System.Drawing.Point(2, 139);
            this.listBoxStories.Name = "listBoxStories";
            this.listBoxStories.Size = new System.Drawing.Size(312, 260);
            this.listBoxStories.TabIndex = 8;
            this.listBoxStories.SelectedIndexChanged += new System.EventHandler(this.listBoxStories_SelectedIndexChanged);
            // 
            // trackBarRate
            // 
            this.trackBarRate.LargeChange = 1;
            this.trackBarRate.Location = new System.Drawing.Point(578, 611);
            this.trackBarRate.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarRate.Maximum = 8;
            this.trackBarRate.Minimum = 1;
            this.trackBarRate.Name = "trackBarRate";
            this.trackBarRate.Size = new System.Drawing.Size(352, 45);
            this.trackBarRate.TabIndex = 9;
            this.trackBarRate.Value = 4;
            this.trackBarRate.Scroll += new System.EventHandler(this.trackBarRate_Scroll);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnPauseResume.Location = new System.Drawing.Point(652, 415);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(148, 40);
            this.btnPauseResume.TabIndex = 10;
            this.btnPauseResume.Text = "Pause/Resume";
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStop.Location = new System.Drawing.Point(851, 415);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(84, 40);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(95, 448);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(189, 26);
            this.comboBoxCategory.TabIndex = 13;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(377, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Story Reader";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVolumeValue
            // 
            this.labelVolumeValue.AutoSize = true;
            this.labelVolumeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelVolumeValue.Location = new System.Drawing.Point(350, 620);
            this.labelVolumeValue.Name = "labelVolumeValue";
            this.labelVolumeValue.Size = new System.Drawing.Size(82, 18);
            this.labelVolumeValue.TabIndex = 15;
            this.labelVolumeValue.Text = "Volume: 50";
            // 
            // labelRateValue
            // 
            this.labelRateValue.AutoSize = true;
            this.labelRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelRateValue.Location = new System.Drawing.Point(925, 620);
            this.labelRateValue.Name = "labelRateValue";
            this.labelRateValue.Size = new System.Drawing.Size(66, 18);
            this.labelRateValue.TabIndex = 16;
            this.labelRateValue.Text = "Speed: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Theme:";
            // 
            // comboBoxVoices
            // 
            this.comboBoxVoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxVoices.FormattingEnabled = true;
            this.comboBoxVoices.Location = new System.Drawing.Point(652, 491);
            this.comboBoxVoices.Name = "comboBoxVoices";
            this.comboBoxVoices.Size = new System.Drawing.Size(283, 28);
            this.comboBoxVoices.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Choose a story to play:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "STORY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(448, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Choose Voice:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRateValue);
            this.Controls.Add(this.labelVolumeValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxVoices);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPauseResume);
            this.Controls.Add(this.trackBarRate);
            this.Controls.Add(this.listBoxStories);
            this.Controls.Add(this.btnLoadStories);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.richTextBoxStory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxStory;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnLoadStories;
        private System.Windows.Forms.ListBox listBoxStories;
        private System.Windows.Forms.TrackBar trackBarRate;
        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVolumeValue;
        private System.Windows.Forms.Label labelRateValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVoices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

