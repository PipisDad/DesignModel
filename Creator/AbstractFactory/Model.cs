using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Creator.AbstractFactory
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public interface Type
    {

    }


    public class Chair:Type
    {
        public Chair()
        {
            Console.WriteLine("生产了 椅子");
        }
    }

    public class Desk : Type
    {
        public Desk()
        {
            Console.WriteLine("生产了 桌子");
        }
    }

    public interface MadeBy
    {

    }

    public class Wood : MadeBy
    {
        public Wood()
        {
            Console.WriteLine("木头做的");
        }
    }

    public class Paper : MadeBy
    {
        public Paper()
        {
            Console.WriteLine("纸做的");
        }
    }

    /// <summary>
    /// 创建工厂
    /// </summary>
    public interface AbstractFactory
    {
        Type CreateType();
        MadeBy CreateMadeby();
    }

    public class WoodDesk:AbstractFactory
    {
        public MadeBy CreateMadeby()
        {
            return new Wood();
        }

        public Type CreateType()
        {
            return new Desk();
        }
    }

    public class PaperChair : AbstractFactory
    {
        public MadeBy CreateMadeby()
        {
            return new Paper();
        }

        public Type CreateType()
        {
            return new Chair();
        }
    }
}
