using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Structural
{
    public abstract class Folder
    {
        public abstract void Add(Folder folder);
        public abstract void Remove(Folder folder);
        public abstract void Open();
    }

    public sealed class Text_1 : Folder
    {
        public override void Add(Folder folder)
        {
            Console.WriteLine("Text文档不支持");
        }

        public override void Open()
        {
            Console.WriteLine("打开了txt文档");
        }

        public override void Remove(Folder folder)
        {
            Console.WriteLine("Text文档不支持");
        }
    }

    public class ChildrenFolder : Folder
    {
        public override void Add(Folder folder)
        {
            Console.WriteLine("添加文件成功");
        }

        public override void Open()
        {
            Console.WriteLine("打开文件成功");
        }

        public override void Remove(Folder folder)
        {
            Console.WriteLine("删除文件成功");
        }
    }
}
