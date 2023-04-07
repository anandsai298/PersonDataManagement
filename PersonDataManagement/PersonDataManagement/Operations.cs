using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Operations
    {
        public void RetriveTopRecordsOfAge(List<Person> persons)
        {
            var data = persons.Where(x => x.Age < 60).ToList().Take(2);
            foreach (var result in data)
            {
                Console.WriteLine("Sno-->" + result.SSN+ "Name-->" + result.Name+ "Address-->" + result.Address+ "Age-->" + result.Age);
            }
        }
        public void RetriveAllRecordsOfAge(List <Person> persons)
        {
            var data = persons.Where(x => x.Age < 30 && x.Age > 20).ToList();
            foreach (var result in data)
            {
                Console.WriteLine("Sno-->" + result.SSN + "Name-->" + result.Name + "Address-->" + result.Address + "Age-->" + result.Age);
            }
        }
        public void RetriveAverageAge(List <Person> persons)
        {
            var data=persons.Average(x => x.Age);
            Console.WriteLine(data.ToString());
        }
    }
}
