using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpecFlow.Selenium.Models
{
    public class TestData
    {
        public List<User> Users { get; }
        public LoremIpsum LoremIpsum { get; set; }

        public TestData()
        {
            this.Users = InitUsers();
        }
        
        
        // TODO: implement all real users
        private List<User> InitUsers()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream usersStream = assembly.GetManifestResourceStream("SpecFlow.Selenium.Resources.users.json");
            
            if (usersStream == null)
                throw new FileNotFoundException("Could not find users.json resource file");

            var streamReader = new StreamReader(usersStream);
            var jToken = JToken.Parse(streamReader.ReadToEnd());
            var jsonReader = jToken.SelectToken("users").CreateReader();

            var jsonSerializer = new JsonSerializer();
            var users = (List<User>) jsonSerializer.Deserialize(jsonReader, typeof(List<User>));

            return users;
        }
    }
}