using System;

namespace CreationPatterns
{
    public sealed class Singleton
    {
        public int ID { get; private set; }
        public string Description { get; }

        private static readonly Singleton _instance = new Singleton();

        // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
        static Singleton() { }

        //Default constructor as private
        private Singleton()
        {
            ID = 1;
            Description = "There should only be one of me!";
        }

        public static Singleton Instance { get { return _instance; } }
    }
}
