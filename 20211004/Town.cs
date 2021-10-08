using System;
using System.Collections.Generic;
using System.Linq;

namespace MockAssessment3
{
    public class Town 
    {
        public List<IVillager> Villagers = new List<IVillager>();

        public Town()
        {
            Villagers.Add(new Farmer());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
        }

        public int Harvest ()
        { 
            return Villagers.Sum(v => v.Farm());

            // var counter = 0;
            // foreach(var Villager in Villagers)
            // {
            //     counter += Villager.Farm();
            // }
            // return counter;
        } 

        public int CalcFoodConsumption()
        {
            return Villagers.Sum(v => v.Hunger);

            // int hungerTotal = 0;
            // foreach (IVillager x in Villagers)
            // {
            //     hungerTotal += x.Hunger;
            // }

            // return hungerTotal;
        }

        public bool SurviveTheWinter()
        {
            int harvest = Harvest();
            int hunger = CalcFoodConsumption();

            return hunger <= harvest;
            
            // if (hunger <= harvest)
            // {
            //     return true;
            // }
            // else
            // {
            //     return false;
            // }
        }
    }
}