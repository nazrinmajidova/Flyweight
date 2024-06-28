using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Bullet
    {
        private EnumBulletSize bulletSize;

        public Bullet(EnumBulletSize bulletSize)
        {
            this.bulletSize = bulletSize;

            Console.WriteLine(bulletSize + " mm mermi oluştu");
            Thread.Sleep(100); // 0.1 san 

        }

        public void ToFire()
        {
            Console.WriteLine("Tak");
        }
    }
}
