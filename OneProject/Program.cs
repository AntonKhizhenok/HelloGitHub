using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneProject
{
    abstract class Weapon
    {
        public abstract string Color { get; }
        public abstract void Recoil();

        public void ShowInfo()
        {
         Console.WriteLine(GetType().Name);
        }
        public void ItemColor()
        {
            Console.WriteLine(Color);
        }
    }
    class Gun : Weapon
    {
        public override string Color { get { return "Black"; } }

        public override void Recoil()
        {
            
            Console.WriteLine("Отдача большая");
        }
    }
    class LaserGun : Weapon
    {
        public override string Color { get { return "Violet"; } }

        public override void Recoil()
        {
           
            Console.WriteLine("Отдача не большая");
        }
    }
    class Bow : Weapon
    {
        public override string Color => "Green";

        public override void Recoil()
        {
            
            Console.WriteLine("Отдача отсутствует");
        }
    }

    class Player
    {
        public void Otdacha(Weapon weapon)
        {
            weapon.Recoil();
        }
        public void CheckInfo(Weapon weapon)
        {
            weapon.ShowInfo();
        }
        public void CheckColor(Weapon weapon)
        {
            weapon.ItemColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] weapons = { new Gun(), new LaserGun(), new Bow()};
            foreach (var item in weapons)
            {
                player.CheckInfo(item);
                player.CheckColor(item);
                player.Otdacha(item);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
