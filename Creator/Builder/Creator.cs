using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Creator.Builder
{
    public class Animal
    {
        public string Color { get; set; }
        public string Foot { get; set; }
        public string Sound { get; set; }
    }

    /// <summary>
    /// 创捷者接口
    /// </summary>
    public abstract class Builder
    {
        protected Animal Animal { get; set; }


        public Builder()
        {
            Animal = new Animal();
        }

        public abstract void BuildColor();
        public abstract void BuildFoot();
        public abstract void BuildSound();

        public Animal GetAnimal()
        {
            return Animal;
        }
    }

    public class CatBuilder : Builder
    {
        public override void BuildColor()
        {
            Animal.Color = "梨花斑";
        }

        public override void BuildFoot()
        {
            Animal.Foot = "4条腿";
        }

        public override void BuildSound()
        {
            Animal.Sound = "喵喵喵";
        }
    }

    public class SupereManBuilder : Builder
    {
        public override void BuildColor()
        {
            Animal.Color = "灰色";
        }

        public override void BuildFoot()
        {
            Animal.Foot = "2条腿";
        }

        public override void BuildSound()
        {
            Animal.Sound = "迪迦";
        }
    }
    public class AnimalDirector
    {
        Builder builder;
        public AnimalDirector(Builder builder)
        {
            this.builder = builder;
        }
        public Animal BuilderAnimal()
        {
            builder.BuildColor();
            builder.BuildFoot();
            builder.BuildSound();

            return builder.GetAnimal();
        }
    }
}
