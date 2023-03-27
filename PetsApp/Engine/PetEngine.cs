using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetsApp.Model;
using System.Threading;

namespace PetsApp
{
    public class PetEngine
    {
        private List<PetModel> petDatabase = new List<PetModel>();

        public void addPet(int id, string name, string petType)
        {
            switch (petType)
            {
                case "Dog":
                    petDatabase.Add(new Dog(id, name));
                    break;
                case "Cat":
                    petDatabase.Add(new Cat(id, name));
                    break;
                case "Plant":
                    petDatabase.Add(new Plant(id, name));
                    break;
                case "Fish":
                    petDatabase.Add(new Fish(id, name));
                    break;
            }
        }

        public string getTime(PetModel pet)
        {
            var currentTime = pet.Timer - (DateTime.Now - pet.StartingTime).TotalMilliseconds / 1000 % pet.Timer;
            var timeElapsed = (DateTime.Now - pet.StartingTime).TotalMilliseconds/1000;
            if (pet.Timer < timeElapsed)
            {
                pet.StartingTime = DateTime.Now;
                pet.Hunger++;
                pet.Happiness--;
                pet.checkThreshholds(pet.Hunger, pet.Happiness);
            }
            return TimeSpan.FromMinutes((double)currentTime).ToString();
        }

        public PetModel getPet(int id)
        {
            if (id >= 0)
            {
                try
                {
                    foreach (var pet in petDatabase)
                    {
                        if (pet.ID == id)
                        {
                            return pet;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString() + " PetEngine/getPet failed");
                }
            }
            Console.WriteLine("No pet found with this ID");
            return null;
        }

        public void removePet(int id)
        {
            petDatabase.Remove(getPet(id));
        }

        public void feedPet(int id, string food)
        {
            var pet = getPet(id);
            if (pet != null)
            {
                pet.Feed(food);
            }
        }

        public void interactPet(int id, string interaction)
        {
            var pet = getPet(id);
            if (pet != null && pet.isHealthy())
            {
                pet.Interact(interaction);
            }
        }
    }
}
