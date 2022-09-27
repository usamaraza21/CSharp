using System;
using System.Collections.Generic;

namespace linqLibrary
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new List<Person>();
            output.Add( new Person{firstName = "Usama" , lastName = "Raza" , birthday = Convert.ToDateTime("02/28/1998") , yearExperience = 1} );
            output.Add( new Person{firstName = "Adeel" , lastName = "Khan" , birthday = Convert.ToDateTime("04/06/1993") , yearExperience = 4} );
            output.Add( new Person{firstName = "Akrima" , lastName = "Sait" , birthday = Convert.ToDateTime("09/06/1995") , yearExperience = 2} );
            output.Add( new Person{firstName = "Taha" , lastName = "Ahmed" , birthday = Convert.ToDateTime("07/20/1992") , yearExperience = 6} );
            output.Add( new Person{firstName = "Umer" , lastName = "Khan" , birthday = Convert.ToDateTime("02/22/1997") , yearExperience = 2} );
            return output;
        }
    }
}