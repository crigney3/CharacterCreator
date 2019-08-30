using System;
using System.Collections.Generic;
namespace CharacterCreationTest
{
    public enum SizeEnum
    {
        Tiny,
        Small,
        Medium,
        Large,
        Huge,
        Gargantuan
    }

    public enum AlignmentEnum
    {
        LawfulGood,
        NeutralGood,
        ChaoticGood,
        LawfulNeutral,
        TrueNeutral,
        ChaoticNeutral,
        LawfulEvil,
        NeutralEvil,
        ChaoticEvil
    }

    public class Character
    {
        private Race charRace;
        private Class charClass;
        private Dictionary<string, int> stats;
        private Dictionary<string, int> modifiers;
        private string name;
        private string playerName;
        private int height;
        private int weight;
        private SizeEnum size;

        public Character()
        {
            
        }
    }
}
