using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    public  interface IList
    {
        public  List<Player> PLayerList(int size);
        public  string FindPlayer(List<Player> list, int index);
    }
}
