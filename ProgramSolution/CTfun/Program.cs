using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;//Used for JSON parsing

namespace CTfun
{

    class Program
    {

        //json2csharp converting
        public class Geo
        {
            public string lat { get; set; }
            public string lng { get; set; }
        }

        public class Address
        {
            public string street { get; set; }
            public string suite { get; set; }
            public string city { get; set; }
            public string zipcode { get; set; }
            public Geo geo { get; set; }
        }

        public class Company
        {
            public string name { get; set; }
            public string catchPhrase { get; set; }
            public string bs { get; set; }
        }

        public class Users
        {
            public int id { get; set; }
            public string name { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public Address address { get; set; }
            public string phone { get; set; }
            public string website { get; set; }
            public Company company { get; set; }
        }
        static void Main(string[] args)
        {

            var client = new WebClient();
            var content = client.DownloadString("https://jsonplaceholder.typicode.com/users");//JSON content

            Users[] result=JsonConvert.DeserializeObject<Users[]>(content);//deserialization and insertion in array
            
            //Console.WriteLine(result[0].name); //Showing name atribute from firs object in array
            //Console.ReadLine(); //Hold on

            /* email of users
            foreach (Users i in result)
            {
                Console.WriteLine(i.email);
            }
            Console.ReadLine();
            */
            //brojaci domena
            int biz = 0;
            int tv = 0;
            int net = 0;
            int org = 0;
            int ca = 0;
            int info = 0;
            int me = 0;
            int io = 0;

            foreach (Users i in result)
            {

                if (i.email.Contains(".biz")) { biz++; }
                else if (i.email.Contains(".biz")) { biz++; }
                else if (i.email.Contains(".tv")) { tv++; }
                else if (i.email.Contains(".net")) { net++; }
                else if (i.email.Contains(".org")) { org++; }
                else if (i.email.Contains(".ca")) { ca++; }
                else if (i.email.Contains(".info")) { info++; }
                else if (i.email.Contains(".me")) { me++; }
                else if (i.email.Contains(".io")) { io++; }
            }

            Console.WriteLine("Number of users with email domains:\n");

            Console.WriteLine("Users with domain .biz : " +biz);
            Console.WriteLine("Users with domain .tv : " + tv);
            Console.WriteLine("Users with domain .net : " + net);
            Console.WriteLine("Users with domain .org : " + org);
            Console.WriteLine("Users with domain .ca : " + ca);
            Console.WriteLine("Users with domain .info : " + info);
            Console.WriteLine("Users with domain .me : " + me);
            Console.WriteLine("Users with domain .io : " + io);

            Console.WriteLine("\nPress ENTER to finish!");
            Console.ReadLine();

        }

    }
}