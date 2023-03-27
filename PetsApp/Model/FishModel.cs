using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PetsApp.Model
{
    public class Fish : PetModel
    {
        //PetModel(int id, string name, int hunger, int happiness, int maxHunger, int maxHappiness,int startingTime, int timer, string petType)
        public Fish(int id, string name) : base(id, name, 2, 5, 10, 10,DateTime.Now, 180, "Fish")
        {

        }

        public override void Feed(string food)
        {
            try
            {
                switch (food.ToLower())
                {
                    case "fish food":
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
                //TODO: Log exception on logfile and throw error
                Console.WriteLine(ex.Message);
            }
        }

        public override void Interact(string action)
        {
            try
            {
                switch (action.ToLower())
                {
                    case "play music":
                        Hunger++;
                        Happiness++;
                        break;
                    case "talk to them":
                        Hunger++;
                        Happiness++;
                        break;
                    case "tap on glass":
                        Hunger += 3;
                        Happiness -= 2;
                        break;
                    default:
                        dislikeInteraction();
                        break;
                }
            }
            catch (Exception ex)
            {
                //TODO: Log exception on logfile and throw error
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
