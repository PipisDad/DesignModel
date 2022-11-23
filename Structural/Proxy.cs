using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Structural
{
    public class Cat_2
    {
        string name;
        public Cat_2(string color)
        {
            this.name = color;
        }
        public string GetColor()
        {
            return name;
        }
        public void SetColor(string color)
        {
            this.name = color;
        }
    }

    //声明接口
    public interface IFeet
    {
        void EatFish();
        void EatMeat();
        void DrinkWater();
    }
    public class Man:IFeet
    {
        Cat_2 cat;
        public Man(Cat_2 cat)
        {
            this.cat = cat;
        }

        public void DrinkWater()
        {
            Console.WriteLine($"给 {cat.GetColor()} 喂水");
        }

        public void EatFish()
        {
            Console.WriteLine($"给 {cat.GetColor()} 喂鱼");
        }

        public void EatMeat()
        {
            Console.WriteLine($"给 {cat.GetColor} 喂肉");
        }
    }
    //代理对象
    public class Roommate:IFeet
    {
        Man man;
        public Roommate(Cat_2 cat)
        {
            man = new Man(cat);
        }

        public void DrinkWater()
        {
            man.DrinkWater();
        }

        public void EatFish()
        {
            man.EatFish();
        }

        public void EatMeat()
        {
            man.EatMeat();
        }
    }

    internal class Proxy
    {
    }
}
