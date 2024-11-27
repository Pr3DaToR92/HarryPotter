using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Characters
    {
        string _characterName;
        House _houseName;
        Item _itemType;

        public Characters(string characterName, string HouseName)
        {
            _characterName = characterName;
            _houseName = new House(HouseName);
        }
    }

}
