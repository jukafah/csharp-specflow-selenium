using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpecFlow.Selenium.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}