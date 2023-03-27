using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PetsApp.Model
{
    public class Cat : PetModel
    {

        //PetModel(int id, string name, int hunger, int happiness, int maxHunger, int maxHappiness, Timer timer, string petType)
        public Cat(int id, string name) : base(id, name,2, 4, 8, 5, DateTime.Now, 120, "Cat")
        {

        }
        public override void Feed(string food)
        {
            try
            {
                switch (food.ToLower())
                {
                    case "tuna":
                        Hunger = 0;
                        Happiness += 3;
                        break;
                    case "dry cat food":
                        Hunger /= 2;
                        Happiness += 1;
                        break;
                    default:
                        dislikeFood();
                        break;
                }
                checkThreshholds(Hunger, Happiness);
            }
            catch (Exception ex)
            {
                //TODO: Log excception somewhere and throw error
                Console.WriteLine(ex.Message);
            }
        }

        public override void Interact(string action)
        {
            try
            {
                switch (action.ToLower())
                {
                    case "pet":
                        Random rand = new Random();
                        if (rand.Next(0, 100) >= 50)
                        {
                            Hunger += 1;
                            Happiness += 1;
                        }
                        else
                            dislikeInteraction();
                        break;
                    case "ignore":
                        Hunger += 1;
                        Happiness += 2;
                        break;
                    case "scold":
                        Hunger += 2;
                        Happiness -= 2;
                        break;
                    default:
                        dislikeInteraction();
                        break;
                }
            }
            catch (Exception ex)
            {
                //TODO: Log exception somewhere and throw error
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
