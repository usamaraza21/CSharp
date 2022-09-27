using System;
using System.Collections.Generic;

namespace linqLibrary
{
    public class Person
    {
        public string? firstName { get ; set; }
        public string? lastName { get; set; }
        public int yearExperience { get; set; }
        public DateTime birthday { get; set; }

        public string fullName 
        {
            get 
            {
                return $"{firstName} {lastName} " ;
            }
        }
    }
}