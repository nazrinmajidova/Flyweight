namespace Flyweight
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldierList = new List<Soldier>();

            Yuzbasi yuzbasi = new Yuzbasi();
            soldierList.Add(yuzbasi);

            for (int i = 0; i < 50; i++)
            {
                Er er = new Er();
                soldierList.Add(er);
            }

            foreach (Soldier soldier in soldierList)
            {
                soldier.Fire();
            }

            foreach (Soldier soldier in soldierList)
            {
                soldier.Tara();
            }
        }
    }

}

