using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    public class FamilyTree
    {
        public void findingGender(string name, string connection)
        {
            
        }

        public Human addingRoot(string name, string sex)
        {
            if (sex == "erkek")
            {
                Human root = new Human(name, Gender.Male);
                Human associatedHuman = root;
                return root;
            }
            else
            {
                Human root = new Human(name, Gender.Female);
                Human associatedHuman = root;
                return root;
            }
        }
    }
}
