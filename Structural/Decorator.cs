using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Structural
{
    public abstract class Component
    {
        public abstract void Display();
    }
    public class Cat:Component
    {
        public override void Display()
        {
            Console.WriteLine("我是一只猫");
        }
    }
    public class Bird:Component
    {
        public override void Display()
        {
            Console.WriteLine("我是一只鸟");
        }
    }

    //构件装饰类
    public class ComponentDecorator:Component
    {
        private Component component;
        public ComponentDecorator(Component component)
        {
            this.component = component;
        }

        public override void Display()
        {
            component.Display();
        }
    }
    //为动物装饰颜色
    public class WhiteDecorator : ComponentDecorator
    {
        public WhiteDecorator(Component component) : base(component)
        {
        }
        public override void Display()
        {
            SetCorlor();
            base.Display();
        }
        private void SetCorlor()
        {
            Console.WriteLine("为动物装饰为黑色");
        }
    }
    public class WingDecorator : ComponentDecorator
    {
        public WingDecorator(Component component) : base(component)
        {
        }
        public override void Display()
        {
            SetCorlor();
            base.Display();
        }
        private void SetCorlor()
        {
            Console.WriteLine("为动物装饰翅膀");
        }
    }
}
