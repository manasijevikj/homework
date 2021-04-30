using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain2.Classes
{
    public static class PetStore<T> where T : Pet
    {
        public static List<T> PetsList;

        static PetStore()
        {
            PetsList = new List<T>();
        }

        public static void PrintsPets()
        {
            foreach(T t in PetsList)
            {
                t.PrintInfo();
            }
        }

        public static void BuyPet(string name)
        {

            T pet = PetsList.FirstOrDefault(p => p.Name == name);
            if(pet != null)
            {
                Console.WriteLine("The pet is removed from the list");
                PetsList.Remove(pet);
            }
            else
            {
                Console.WriteLine("There is not pet with that name");
            }
        }
        
    }
}
 