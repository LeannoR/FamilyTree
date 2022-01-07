using System;

namespace FamilyTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var familyTree = new FamilyTree();
            var operations = new Operations(); 
            //var associatedHuman = new Human(" ",Gender.Male);
            Console.WriteLine("Lütfen soyağacının ilk üyesini adını ve cinsiyetini boşluk bırakarak giriniz");
            var information = Console.ReadLine();
            string[] informations = information.Split(' ');
            string nameRoot = informations[0];
            string sexRoot = informations[1];
            if(sexRoot != "erkek" || sexRoot != "kadın")
            {
                Console.WriteLine("Yanlış karakter girdiniz");
            }
            else
            {
                familyTree.addingRoot(nameRoot, sexRoot);
            }
            if(operations.Menu() == 1)
            {
                Console.WriteLine("Lütfen aile üyesinin ismini ve bağlantısı olan kişiyi akraba bağınızın ne olduğu ile de giriniz");
                var memberInformation = Console.ReadLine();
                string[] memberInformations = information.Split(' ');
                string memberName = memberInformations[0];
                string associatedMembersname = memberInformations[1];
                string associatedMembersconnection = memberInformations[2];
                if(associatedMembersname != nameRoot)
                {
                    Console.WriteLine("Bağlantı kurmak istediğiniz aile üyesinin ismi yanlış");
                }
                else
                {
                    familyTree.findingGender(associatedMembersname, associatedMembersconnection);
                }
            }
            else if(operations.Menu() == 2)
            {

            }
            else
            {
                Console.WriteLine("Yanlış karakter girdiniz");
            }
        }
    }
}
