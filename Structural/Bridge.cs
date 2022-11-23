using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Structural
{
    public interface Color
    {
        void SetShape(string shape);
    }

    public abstract class Shape
    {
        public Color color;
        public void SetColor(Color color)
        {
            this.color = color;
        }
        public abstract void Draw();
    }

    public class Circle:Shape
    {
        public override void Draw()
        {
            color.SetShape("圆形");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            color.SetShape("三角形");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            color.SetShape("正方形");
        }
    }

    public class White : Color
    {
        public void SetShape(string shape)
        {
            Console.WriteLine($"白色的：{shape}");
        }
    }
    public class Black : Color
    {
        public void SetShape(string shape)
        {
            Console.WriteLine($"黑色的：{shape}");
        }
    }
}
