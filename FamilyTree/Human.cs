using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    public class Human
    {
        public string Name { get; }
        public Gender Gender { get; }
        public Human Spouse { get; set; }
        public Human Child { get; set; }
        public Human(string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
        }
   
    }
    public enum Gender
    {
        Male,
        Female
    }
}
