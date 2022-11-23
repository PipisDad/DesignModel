using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Creator.Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padLock = new object();

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(padLock)
                    {
                        if(instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
