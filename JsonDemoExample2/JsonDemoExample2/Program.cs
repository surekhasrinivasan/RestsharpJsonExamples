using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemoExample2
{
    // Program to demo serialize and deserialize
    public class Account
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Serialize an object to JSON
            //Account account = new Account()
            //{
            //    Email = "james@example.com",
            //    Active = true,
            //    CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
            //    Roles = new List<string>
            //    {
            //        "User",
            //        "Admin"
            //    }
            //};

            //string json = JsonConvert.SerializeObject(account, Formatting.Indented);

            //Console.WriteLine(json);


            // Deserialize JSON to Object 
            string jsonstr = @"{
                    'Email': 'james@example.com',
                    'Active': 'true',
                    'CreatedDate': '2013-01-20',
                    'Roles': [
                        'User',
                        'Admin'
                    ]
              }";

            Account acct = JsonConvert.DeserializeObject<Account>(jsonstr);

            Console.WriteLine(acct.Email);
            Console.WriteLine(acct.CreatedDate);
        }
    }
}
