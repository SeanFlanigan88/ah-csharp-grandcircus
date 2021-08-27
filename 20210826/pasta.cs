using System;

namespace _20210826
{
    public class Pasta
    {
        public static bool HasGluten = true;
        public string Shape;
        public float Pounds;
        public string ID;

        public Pasta(string ID)
        {
            this.ID = ID;
        }

        public string GetID()
        {
            return ID;
        }
    }
}