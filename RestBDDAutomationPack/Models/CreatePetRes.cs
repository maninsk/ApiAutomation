using System;
using System.Collections.Generic;
using System.Text;

namespace RestBDDAutomationPack
{

    public class CreatePetRes

    {
        public int id { get; set; }
        public Category category { get; set; }
        public string name { get; set; }
        public string[] photoUrls { get; set; }
        public Tag[] tags { get; set; }
        public string status { get; set; }
    }

    public class CreatePetResCategory
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class CreatePetResTag
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
