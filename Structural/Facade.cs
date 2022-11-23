using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Structural
{
    #region 外部系统
    public class SubSystem_1
    {
        public void Mehhod_1()
        {
            Console.WriteLine("我是 1111");
        }
        public void Mehhod_2()
        {
            Console.WriteLine("我是 222");
        }
    }

    public class SubSystem_2
    {
        public void Mehhod_1()
        {
            Console.WriteLine("我是 3333");
        }
        public void Mehhod_2()
        {
            Console.WriteLine("我是 4444");
        }
    }
    #endregion

    public class Facade
    {
        private SubSystem_1 subSystem_1;
        private SubSystem_2 subSystem_2;

        public Facade()
        {
            subSystem_1 = new SubSystem_1();
            subSystem_2 = new SubSystem_2();
        }

        public void Method_A()
        {
            Console.WriteLine("Method A 包含 1、3");
            subSystem_1.Mehhod_1();
            subSystem_2.Mehhod_1();
        }
        public void Method_B()
        {
            Console.WriteLine("Method A 包含 2、4");
            subSystem_1.Mehhod_2();
            subSystem_2.Mehhod_2();
        }
    }
}
