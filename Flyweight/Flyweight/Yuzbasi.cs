using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Yuzbasi : Soldier
    {
        public Yuzbasi() : base(EnumBulletSize.FIVE)
        {
            // Constructor calls the base class constructor with EnumMermiBoyutu.BES
        }

        public override void Fire()
        {
            Console.WriteLine("Yuzbasi ates ediyor!");
        }

        public override void Tara()
        {
            Console.WriteLine("Yuzbasi tarama yapiyor!");
        }
    }
}
