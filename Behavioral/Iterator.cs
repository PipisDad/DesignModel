using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Behavioral
{
    public class MenuItem
    {
        private string name;
        private string description;
        private int channel;

        public MenuItem(int channel, string name, string des)
        {
            this.Channel = channel;
            this.Description = des;
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Description
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.description))
                {
                    this.description = this.Name;
                }
                return this.description;
            }
            set { this.description = value; }
        }
        public int Channel
        {
            get { return this.channel; }
            set { this.channel = value; }
        }
    }


    //抽象迭代器
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }

    //具体迭代器
    public class FilmMenuIterator : Iterator
    {
        MenuItem[] menuItems = null;
        int pos = 0;

        public FilmMenuIterator(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext()
        {
            if (pos > menuItems.Count() - 1 || menuItems[pos] == null)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            MenuItem menuItem = menuItems[pos];
            pos++;
            return menuItem;
        }
    }

    //具体迭代器
    public class TVChannelMenuIterator : Iterator
    {
        MenuItem[] menuItems = null;
        int pos = 0;

        public TVChannelMenuIterator(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext()
        {
            if (pos > menuItems.Count() - 1 || menuItems[pos] == null)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            MenuItem menuItem = menuItems[pos];
            pos++;
            return menuItem;
        }
    }

    //抽象聚合类
    public interface ITelevisionMenu
    {
        void AddItem(int channel, string name, string des);
        Iterator CreateIrerator();
    }

    

    //具体聚合类
    public class FilmMenu : ITelevisionMenu
    {
        public const int maxLen = 8;
        MenuItem[] menuItems;
        int numberOfItems = 0;

        public FilmMenu()
        {
            menuItems = new MenuItem[maxLen];

            AddItem(1, "肖申克的救赎", "越狱");
            AddItem(2, "这个杀手不太冷", "萝莉和大叔");
            AddItem(3, "三国演义", "萝莉和大叔");
            AddItem(4, "四方天地", "越狱");
            AddItem(5, "五星红旗", "");
            AddItem(6, "张麻子", "");
            AddItem(7, "7个小矮人", "白雪公主");
            AddItem(8, "8号当铺", "");
            AddItem(9, "我是9号", "");
            AddItem(10, "我是10号", "萝莉和大叔");
        }

        public void AddItem(int channel, string name, string des)
        {
            MenuItem item = new MenuItem(channel, name, des);

            if(numberOfItems>=maxLen)
            {
                Console.WriteLine("电影添加失败，已满");
            }
            else
            {
                menuItems[numberOfItems] = item;
                numberOfItems++;
            }
        }

        public Iterator CreateIrerator()
        {
            return new FilmMenuIterator(menuItems);
        }
    }

    public class TVChannelMenu:ITelevisionMenu
    {
        MenuItem[] menuItems;
        int numberOfItems = 0;
        public TVChannelMenu()
        {
            menuItems = new MenuItem[FilmMenu.maxLen];
            AddItem(1, "CCAV-1", "");
            AddItem(2, "CCAV-2", "");
            AddItem(3, "CCAV-3", "");
            AddItem(4, "CCAV-4", "");
            AddItem(5, "CCAV-5", "");
            AddItem(6, "CCAV-6", "");
            AddItem(7, "CCAV-7", "");
            AddItem(8, "CCAV-8", "");
            AddItem(9, "CCAV-9", "");
            AddItem(10, "CCAV-10", "");
        }

        public void AddItem(int channel, string name, string des)
        {
            var item = new MenuItem(channel, name, des);
            if (numberOfItems >= FilmMenu.maxLen)
            {
                Console.WriteLine("电视添加失败，已满");
            }
            else
            {
                menuItems[numberOfItems] = item;
                numberOfItems++;
            }
        }

        public Iterator CreateIrerator()
        {
            return new TVChannelMenuIterator(menuItems);
        }
    }

    public class MainMenu
    {
        ITelevisionMenu tvMenu;
        FilmMenu filmMenu;  

        public MainMenu(ITelevisionMenu televisionMenu, FilmMenu filmMenu)
        {
            this.tvMenu = televisionMenu;
            this.filmMenu = filmMenu;
        }

        public void PrintMenu()
        {
            Iterator tvIterator = tvMenu.CreateIrerator();
            Iterator filmIterator = filmMenu.CreateIrerator();

            Console.WriteLine("电影有：");
            PrintMenu(filmIterator);
            Console.WriteLine("电视有：");
            PrintMenu(tvIterator);
        }
        public void PrintMenu(Iterator iterator)
        {
            while(iterator.HasNext())
            {
                var item = iterator.Next() as MenuItem;
                Console.WriteLine($"频道:{item.Channel} 节目：{item.Name} 讲述了:{item.Description}");
            }
        }
    }
}
