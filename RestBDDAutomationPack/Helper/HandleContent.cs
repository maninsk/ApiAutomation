﻿using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestBDDAutomationPack.Helper
{
    public static class HandleContent
    {
        public static T GetContent<T>(RestResponse response)
        {
            var content = response.Content;
            return JsonConvert.DeserializeObject<T>(content);
        }

        public static string SerializeJsonString(dynamic content)
        {
            return JsonConvert.SerializeObject(content, Formatting.Indented);
        }

        public static T ParseJson<T>(string file)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file));
        }
    }
}
