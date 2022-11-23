using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Structural
{
    public abstract class Device
    {
        public abstract string GetName();
        public void Display()
        {
            var name = GetName();
            Console.WriteLine($"设备名字：{name}");
        }
    }

    public class Computer : Device
    {
        public override string GetName()
        {
            return "计算机";
        }
    }
    public class Camera : Device
    {
        public override string GetName()
        {
            return "摄像头";
        }
    }

    public class DeviceFatory
    {
        private static DeviceFatory m_Instance;
        private static Dictionary<String, Device> m_dic;
        private readonly static object pad =new object();
        private DeviceFatory()
        {
            m_dic = new Dictionary<String, Device>();
            var temp = new Camera();
            m_dic.Add("Camera", temp);
            var temp2 = new Computer();
            m_dic.Add("Computer", temp2);
        }
        public static DeviceFatory Instance
        { 
            get
            {
                if(m_Instance == null)
                {
                    lock(pad)
                    {
                        if(m_Instance == null)
                        {
                            m_Instance = new DeviceFatory();
                        }
                    }
                }

                return m_Instance;
            }
        }

        public Device GetDevice(string name)
        {
            Device res = null;
            m_dic.TryGetValue(name, out res);
            return res;
        }
    }

    internal class Flyweight
    {
    }
}
