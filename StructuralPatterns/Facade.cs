using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StructuralPatterns
{
    public class SpaceStone
    {
        public bool IsSet { get; private set; } = false;

        public void SetSpaceStone(){ IsSet = true; Debug.WriteLine("Space Stone Set"); }
    }

    public class MindStone
    {
        public bool IsSet { get; private set; } = false;

        public void SetMindStone() { IsSet = true; Debug.WriteLine("Mind Stone Set"); }
    }

    public class SoulStone
    {
        public bool IsSet { get; private set; } = false;

        public void SetSoulStone() { IsSet = true; Debug.WriteLine("Soul Stone Set"); }
    }

    public class RealityStone
    {
        public bool IsSet { get; private set; } = false;

        public void SetRealityStone() { IsSet = true; Debug.WriteLine("Reality Stone Set"); }
    }

    public class TimeStone
    {
        public bool IsSet { get; private set; } = false;

        public void SetTimeStone() { IsSet = true; Debug.WriteLine("Time Stone Set"); }
    }

    public class PowerStone
    {
        public bool IsSet { get; private set; } = false;

        public void SetPowerStone() { IsSet = true; Debug.WriteLine("Power Stone Set"); }
    }


    public class InfinityGauntletFacade
    {
        private readonly SpaceStone spaceStone;
        private readonly MindStone mindStone;
        private readonly SoulStone soulStone;
        private readonly RealityStone realityStone;
        private readonly TimeStone timeStone;
        private readonly PowerStone powerStone;

        public InfinityGauntletFacade()
        {
            spaceStone = new SpaceStone();
            mindStone = new MindStone();
            soulStone = new SoulStone();
            realityStone = new RealityStone();
            timeStone = new TimeStone();
            powerStone = new PowerStone();
        }

        public void AssembleInfinityGauntlet()
        {
            spaceStone.SetSpaceStone();
            mindStone.SetMindStone();
            soulStone.SetSoulStone();
            realityStone.SetRealityStone();
            timeStone.SetTimeStone();
            powerStone.SetPowerStone();
        }
    }
}
