using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class House
    {
        string _houseName;
        string _houseColor;

        public House(string houseName)
        {
            _houseName = houseName;
        }

        public string getHouseName()
        {
            return _houseName;
        }
    }
}
