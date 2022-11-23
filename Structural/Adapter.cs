using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Structural
{
    public interface IAnimal
    {
        void Talk();
        void Move();
    }

    public class Chicken : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("蹦蹦跳跳");
        }

        public void Talk()
        {
            Console.WriteLine("咯咯咯");
        }
    }

    public class Dog
    {
        public void Move(string name)
        {
            Console.WriteLine($"{name} 随风奔跑");
        }

        public void Talk(string name)
        {
            Console.WriteLine($"{name} 汪汪汪");
        }
    }

    // 适配器：它通过继承目标接口并维护一个适配者对象的引用，使二者关联起来
    public class DogAdapter : IAnimal
    {
        private Dog _dog;

        public DogAdapter(Dog dog)
        {
            this._dog = dog;
        }
        public void Move()
        {
            _dog.Move("小鸡鸡");
        }

        public void Talk()
        {
            _dog.Talk("小鸡鸡");
        }
    }
}
