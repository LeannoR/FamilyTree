using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    public class Operations
    {
        public int Menu()
        {
            Console.WriteLine("1- Soyağacına üye girişi");
            Console.WriteLine("2- Sorgula");
            string strchoice = Console.ReadLine();
            int choice = int.Parse(strchoice);
            return choice;
        }
    }
}
