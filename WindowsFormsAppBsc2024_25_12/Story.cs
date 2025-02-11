using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story_Reader
{
    public class Story
    {
        public string Title { get; set; }
        public string Author { get; set; }
        [JsonProperty("story")]
        public string Content { get; set; }
        public string Category { get; set; }
    }
}
