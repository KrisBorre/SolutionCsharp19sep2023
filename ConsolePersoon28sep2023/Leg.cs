﻿namespace ConsolePersoon28sep2023
{
    public enum Muscularity
    {
        Lean, Fat, Very, Thin
    }

    public class Leg
    {
        public enum LeftOrRight
        {
            Left, Right
        }

        public Muscularity Muscle { get; set; }

        private bool hasKnees;

        public bool HasKnees
        {
            get { return hasKnees; }
            set { hasKnees = value; }
        }

        private LeftOrRight leftOrRight;

        public LeftOrRight LeftOfRight
        {
            get { return leftOrRight; }
            set { leftOrRight = value; }
        }

        public void Running()
        {
            Console.WriteLine("run, mikey, run ...");
        }
    }
}
