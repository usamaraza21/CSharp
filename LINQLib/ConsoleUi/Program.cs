using linqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();
            //people = people.OrderBy(x => x.firstName).ToList();
            //people = people.OrderByDescending(x => x.firstName).ToList();
            //people = people.OrderByDescending(x => x.lastName).ThenByDescending(x => x.yearExperience).ToList();
            //people = people.Where(x => x.yearExperience > 2).ToList();
            //people = people.Where(x => x.yearExperience > 1 && x.birthday.Month > 3).ToList();
            // foreach (var person in people)
            // {
            //     Console.WriteLine($" FullName ->{ person.firstName } { person.lastName } Birthday -> ({ person.birthday.ToShortDateString() }) : Experience -> { person.yearExperience }");   
            // }
            //int yearsTotal = people.Sum(x => x.yearExperience);
            int yearExp = people.Where(x => x.birthday.Month == 2).Sum(x => x.yearExperience);
            Console.Write("Sum of total years : " + yearExp);


            // Console.ReadLine();
        }
    }
}