using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/*
    Installing Newtonsoft.Json...
    go to: Tools -> NuGet Package Manager -> Package Manager Console
    write in console: Install-Package Newtonsoft.Json

    documentation: http://www.newtonsoft.com/json/help/html/Introduction.htm
*/
namespace jsonManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person.Dog[] dogs = { new Person.Dog { name="rex",race="doberman" }, new Person.Dog {name="GenericDogName1", race="somePopularDogRace1" }, new Person.Dog { name = "GenericDogName2", race = "somePopularDogRace2" } };

            p.name = "Joe";
            p.lastName = "Black";
            p.age = 1200;
            p.bithDay = new DateTime(1002, 01, 24);
            p.dogs = dogs;
            p.phoneNumbers = new string[]{ "1243223", "3422343", "56435575","2344009"};

            string json = JsonConvert.SerializeObject(p);
            Console.WriteLine("serializing...");
            Console.WriteLine(json);

            Console.WriteLine("deserializing...");

            Person p2 = JsonConvert.DeserializeObject<Person>(json);

            Console.WriteLine("Accesing properties in new object:");

            Console.WriteLine("Name: "+p2.name);
            Console.WriteLine("Dogs:");
            foreach( Person.Dog d in p2.dogs)
            {
                Console.WriteLine("     "+d.name+", "+d.race);
            }


            //what happen with a list of objects...
            Console.WriteLine("Testing a List...");
            List<Person> lstP = new List<Person>();
            lstP.Add(p);
            lstP.Add(p2);
            string json2 = JsonConvert.SerializeObject(lstP);
            Console.WriteLine(json2);

            //deserializing List
            Console.WriteLine("Deserializing array of objects");
            List<Person> lstP2 = JsonConvert.DeserializeObject<List<Person>>(json2);
            Console.WriteLine("lstPerson[1].name = "+lstP2[1].name);

            Console.Read();
        }
    }
}
