using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Creator.Prototype
{
    public class PersonInfo:ICloneable
    {
        private string name;
        private string sex;
        private int age;
        private string school;
        private string city;

        public PersonInfo(string name)
        {
            this.name = name;
        }

        public void SetBaseInfo(string sex, int age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetSchoolInfo(string school, string city)
        {
            this.school = school;
            this.city = city;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"姓名：{name}");
            Console.WriteLine($"性别：{sex}");
            Console.WriteLine($"年龄：{age}");
            Console.WriteLine($"学校：{school}");
            Console.WriteLine($"城市：{city}");
        }

        public object Clone()
        {
            return MemberwiseClone() as PersonInfo;
        }
    }
}
