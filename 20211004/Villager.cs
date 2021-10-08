using System;

namespace MockAssessment3
{
    public interface IVillager
    {
        int Hunger { get; set; }
        int Farm();
    }

    public class Cart
    {
        public int Hunger { get; set; }

        // public abstract int Farm();
    }

    public abstract class Villager
    {
        public int Hunger { get; set; }

        public abstract int Farm();
    }
    
    public class Farmer : Villager, IVillager
    {
        //public int Hunger { get; set; }

        public Farmer()
        {
            Hunger = 1;
        }

        // public override int Hunger { get { return Hunger; } set { Hunger = value; } }
        
        public override int Farm()
        {
            return 2;
        }
    }

    public class Slacker : IVillager
    {
        public int Hunger { get; set; }

        public Slacker()
        {
            Hunger = 3;
        }

        // public override int Hunger { get { return Hunger; } set { Hunger = value; } }

        public int Farm()
        {
            return 0;
        }
    }
}