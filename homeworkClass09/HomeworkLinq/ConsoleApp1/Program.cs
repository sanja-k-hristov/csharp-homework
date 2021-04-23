using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			// all people aged 50 or more
			List<string> namesOfpeopleabove50 = people
											.Where(x => x.Age >= 50)
											.Select(x => x.FirstName)
											.ToList();
            namesOfpeopleabove50.ForEach(x => Console.WriteLine(x));
			Console.WriteLine("----------------");
            // Task 02
            // all people name starts with B
            List<Person> namesStartsWithB = people
										.Where(x => x.FirstName.StartsWith("B"))
										.ToList();
			namesStartsWithB.ForEach(x => Console.WriteLine(x.FirstName));
			Console.WriteLine("----------------");
			// Task 03
			// first person whose surname starts with T
			Person surnameStartsWithT = people
									.Where(x => x.LastName.StartsWith("T"))
									.First();
			Console.WriteLine(surnameStartsWithT.FirstName);
			Console.WriteLine("----------------");
			// Task 04
			// find youngest and oldest person
			int oldestPerson = people
									.Max(x => x.Age);
			Console.WriteLine(oldestPerson);
			Console.WriteLine("----------------");
			int youngestPerson = people.Min(x => x.Age);
			Console.WriteLine(youngestPerson);
			Console.WriteLine("----------------");
            // Task 05
            // find all male people aged 45 or more
            List<Person> allMaleAged45OrMore = people
                        .Where(x => x.Gender == 'M')
						.Where(x => x.Age >= 45)
                        .ToList();
			allMaleAged45OrMore.ForEach(x => Console.WriteLine(x.FirstName));
			Console.WriteLine("----------------");
			// Task 06
			// find all females whose name starts with V
			List<Person> femalesNameV = people
									.Where(x => x.Gender == 'F')
									.Where(x => x.FirstName.StartsWith("V"))
									.ToList();
			femalesNameV.ForEach(x => Console.WriteLine(x.FirstName));
			Console.WriteLine("----------------");
			// Task 07
			// find last female person older than 30 whose name starts with p
			Person lastFemaleOlder30NameP = people
										.Where(x => x.Gender == 'F')
										.Where(x => x.Age >= 30)
										.Where(x => x.FirstName == "P")
										.LastOrDefault();
			Console.WriteLine(lastFemaleOlder30NameP);
			Console.WriteLine("----------------");
			// Task 08
			// find first male younger than 40
			Person maleYounger40 = people
									.Where(x => x.Gender == 'M')
									.Where(x => x.Age < 40)
									.FirstOrDefault();
			Console.WriteLine(maleYounger40);
			Console.WriteLine("----------------");
			// Task 09
			// print the names of the male persons that have firstName longer than lastName
			List<Person> maleFirstNameLonger = people
									.Where(x => x.FirstName.Length > x.LastName.Length)
									.Where(x => x.Gender == 'M')
									.ToList();
			maleFirstNameLonger.ForEach(x => Console.WriteLine(x.FirstName));
			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			List<Person> lastNamesFemalesOddAge = people
												.Where(x => x.Gender == 'F')
												.Where(x => x.Age % 2 == 1)
												.ToList();
			lastNamesFemalesOddAge.ForEach(x => Console.WriteLine(x.FirstName));

			Console.ReadLine();
		}
    }
}
