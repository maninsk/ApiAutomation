using System.Collections.Generic;

namespace RestBDDAutomationPack
{

    public class Pet
    {
        public int id { get; set; }
        public Category category { get; set; }
        public string name { get; set; }
        public string[] photoUrls { get; set; }
        public List<Tag> tags { get; set; }
        public string status { get; set; }
    }
 }
