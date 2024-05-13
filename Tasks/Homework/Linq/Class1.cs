using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class CharacterData
    {
        public static List<Character> Characters = new List<Character>
    {
        new Character { Clazz = "Warrior", Level = 10, Experience = 1200, Health = 100 },
        new Character { Clazz = "Mage", Level = 12, Experience = 2000, Health = 80 },
        new Character { Clazz = "Warrior", Level = 15, Experience = 3000, Health = 120 },
        new Character { Clazz = "Mage", Level = 11, Experience = 1500, Health = 70 },
        new Character { Clazz = "Warrior", Level = 13, Experience = 2200, Health = 90 },
        new Character { Clazz = "Mage", Level = 14, Experience = 2500, Health = 85 },
        new Character { Clazz = "Warrior", Level = 16, Experience = 3500, Health = 130 },
        new Character { Clazz = "Mage", Level = 17, Experience = 4000, Health = 95 },
        new Character { Clazz = "Warrior", Level = 18, Experience = 4500, Health = 140 },
        new Character { Clazz = "Mage", Level = 20, Experience = 5000, Health = 100 }
    };
    }
}
