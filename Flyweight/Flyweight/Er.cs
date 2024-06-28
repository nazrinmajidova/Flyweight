using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Er : Soldier
    {
        public Er() : base(EnumBulletSize.THREE)
        {
            // Constructor calls the base class constructor with EnumMermiBoyutu.UC
        }

         public override void Fire()
         {
             Console.WriteLine("Er ates ediyor!");
         }

         public override void Tara()
         {
             Console.WriteLine("Er tarama yapiyor!");
         }

    }
}
