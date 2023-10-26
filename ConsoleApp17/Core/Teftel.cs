using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Core
{
    public class Teftel : BaseModel, Endowing
    {
        //private string _name = "";
        private double _hp = 50;
        private int _damage = 20;
        private double _protection = 0.5;
        private int x = 0;

        //public string name { get => _name; set => _name = value; }

        public override void Battle()
        {
            throw new NotImplementedException();
        }

        public override void CharInfo(string name)
        {
            Console.WriteLine($"");
            Console.WriteLine($"Характеристики: {_hp} - хп, {_damage} - урон, {_protection} - коэффициент защиты, {name} - имя");

        }

        public override void Farm()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Speak()
        {
            throw new NotImplementedException();
        }

        public override void Heal()
        {
            throw new NotImplementedException();
        }

        public  void GiveMove(string step)
        {
            if (step == "Вперед") x += 1;

        }
    }
}
