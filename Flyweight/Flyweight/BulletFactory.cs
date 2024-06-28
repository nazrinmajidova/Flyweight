using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class BulletFactory
    {
        private static Dictionary<EnumBulletSize, Bullet> map = new Dictionary<EnumBulletSize, Bullet>();

        public static Bullet CreateBullet(EnumBulletSize bulletSize)
        {
            if (!map.TryGetValue(bulletSize, out Bullet bullet))
            {
                bullet = new Bullet(bulletSize);
                map[bulletSize] = bullet;
            }

            return bullet;
        }
    }
}
