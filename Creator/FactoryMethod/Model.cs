using DesignModel.Creator.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.FactoryMethod
{
    public abstract class MadeBy
    {
        public MadeBy()
        {

        }
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

    public interface FactoryMadeBy
    {
        MadeBy CreateMadeBy();
    }

    public class FactoryWood:FactoryMadeBy
    {
        public MadeBy CreateMadeBy()
        {
            return new Wood();
        }

    }
    public class FactoryPaper : FactoryMadeBy
    {
        public MadeBy CreateMadeBy()
        {
            return new Paper();
        }

    }
}
