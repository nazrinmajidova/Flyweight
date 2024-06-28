using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{

    public abstract class Soldier
        {
            private EnumBulletSize bulletSize;

            public Soldier(EnumBulletSize bulletSize)
            {
                this.bulletSize = bulletSize;
            }

            public virtual void Fire()
            {
            //Bullet bullet = new Bullet(bulletSize);
            Bullet bullet = BulletFactory.CreateBullet(bulletSize);
            bullet.ToFire();
            }

            public virtual void Tara()
            {
                for (int i = 0; i < 5; i++)
                {
                    Fire();
                }
            }
        }

    }

