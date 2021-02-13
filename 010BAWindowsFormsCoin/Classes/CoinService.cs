using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010BAWindowsFormsCoin.Classes
{
    public class CoinService
    {
        Coin coin = new Coin();
        Random random = new Random();

        public Coin ParaAt()
        {
            coin.Yuzu = (byte)random.Next(0, 2);
            return coin;
        }
    }
}
