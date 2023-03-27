using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PetsApp.Model
{
    public class Plant : PetModel
    {
        //PetModel(int id, string name, int hunger, int happiness, int maxHunger, int maxHappiness, int timer, string petType)
        public Plant(int id, string name) : base(id,name, 2, 5, 10, 10, DateTime.Now, 60, "Plant")
        {

        }

        public override void Feed(string food)
        {
            try
            {
                switch (food.ToLower())
                {
                    case "water":
                        Hunger /= 2;
                        Happiness += 1;
                        break;
                    case "plant food":
                        Hunger = 0;
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
                    case "ignore":
                        Hunger += 3; 
                        Happiness -= 3;
                        break;
                    case "play music":
                        Hunger += 1;
                        Happiness += 2;
                        break;
                    case "talk to them":
                        Hunger += 1;
                        Happiness += 1;
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
