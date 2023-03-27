using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetsApp
{
    public class PetModel
    {
        private int id { get; set; }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string name { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string petType { get; set; }
        public string PetType
        {
            get { return petType; }
            set { petType = value; }
        } 
            
        private int hunger { get; set; }
        public int Hunger
        {
            get { return hunger; }
            set { hunger = value; }
        }
        private int happiness { get; set; }
        public int Happiness
        {
            get { return happiness; }
            set { happiness = value; }
        }
        private int maxHunger { get; set; }
        public int MaxHunger
        {
            get { return maxHunger; }
        }
        private int maxHappiness { get; set; }
        public int MaxHappiness
        {
            get { return maxHappiness; }
        }
        private int timer { get; set; }
        public int Timer
        {
            get { return timer; }
            set { timer = value; }
        }
        private DateTime startingTime { get; set; } 
        public DateTime StartingTime
        {
            get { return startingTime; }
            set { startingTime = value; }
        }
        public PetModel(int id, string name, int hunger, int happiness, int maxHunger, int maxHappiness, DateTime startingTime, int timer,string petType)
        {
            this.id = id;
            this.name = name;
            this.hunger = hunger;
            this.happiness = happiness;
            this.maxHunger = maxHunger;
            this.maxHappiness = maxHappiness;
            this.timer = timer;
            this.startingTime = startingTime;
            this.petType = petType;
        }
        public virtual void Feed(string food)
        {

        }

        public virtual void Interact(string action)
        {

        }

        public void checkThreshholds(int hunger, int happiness)
        {
            if(hunger > maxHappiness)
            {
                this.hunger = maxHappiness;
            }else if(hunger < 0)
            {
                this.hunger = 0;
            }

            if(happiness > maxHappiness)
            {
                this.happiness = maxHappiness;
            } else if(happiness < 0)
            {
                this.happiness = 0;
            }
        }
        public void dislikeFood()
        {
            happiness = happiness - 2;
            hunger = hunger + 2;
        }

        public void dislikeInteraction()
        {
            happiness = happiness - 2;
            hunger = hunger + 2;
        }

        public bool isHealthy()
        {
            if (happiness <= 0)
                return false;
            if (hunger >= maxHunger)
                return false;
            return true;
        }
    }
}

