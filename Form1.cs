using DesignModel.Behavioral;
using DesignModel.Creator.AbstractFactory;
using DesignModel.Creator.Builder;
using DesignModel.Creator.Prototype;
using DesignModel.Creator.Singleton;
using DesignModel.FactoryMethod;
using DesignModel.IOC;
using DesignModel.Structural;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //创造型

            //抽象工厂

            //WoodDesk woodDesk = new WoodDesk();
            //woodDesk.CreateMadeby();
            //woodDesk.CreateType();


            //创建者
            //AnimalDirector animalDirector = new AnimalDirector(new CatBuilder());
            //Animal animal = animalDirector.BuilderAnimal();
            //Console.WriteLine(animal.Sound);
            //Console.WriteLine(animal.Color);

            //工厂方法
            //FactoryWood factoryWood = new FactoryWood();
            //DesignModel.FactoryMethod.MadeBy madeBy = factoryWood.CreateMadeBy();


            //原型方法
            //PersonInfo personInfo = new PersonInfo("胖虎");
            //personInfo.SetSchoolInfo("双鸭山大学", "北京");
            //personInfo.SetBaseInfo("男",18);
            //personInfo.PrintInfo();


            //单例模式
            //var temp = Singleton.Instance;


            //结构
            //适配器

            //Chicken chicken = new Chicken();
            //chicken.Talk();
            //chicken.Move();

            //小鸡鸡模拟狗狗
            //Dog dog = new Dog();
            //IAnimal animal = new DogAdapter(dog);
            //animal.Talk();
            //animal.Move();

            //桥接
            //DesignModel.Structural.Color white = new White();
            ////白色的长方形
            //Shape square = new Square();
            //square.SetColor(white);
            //square.Draw();

            //白色长方形
            //Shape rectange = new DesignModel.Structural.Rectangle();
            //rectange.SetColor(white);
            //rectange.Draw();

            //组合
            //Folder folder = new ChildrenFolder();
            //folder.Open();
            //folder.Add(new ChildrenFolder());
            //folder.Remove(new ChildrenFolder());

            //Folder text = new Text_1();
            //text.Open();
            //text.Add(folder);
            //text.Remove(folder);


            //装饰器
            //Component component = new Cat();
            //var componentBlack = new WhiteDecorator(component);
            //Component componentWing = new WingDecorator(componentBlack);
            //componentWing.Display();

            //外观模式
            //Facade facade = new Facade();
            //facade.Method_A();
            //facade.Method_B();

            //享元
            //DeviceFatory deviceFatory = DeviceFatory.Instance;
            //Device camera = deviceFatory.GetDevice("Computer");
            //Device camera2 = deviceFatory.GetDevice("Computer");
            //Console.WriteLine($"是否相等:{camera == camera2}");
            //camera.Display();
            //camera2.Display();

            //代理
            //Cat_2 cat = new Cat_2("啊黄");
            //Roommate roommate = new Roommate(cat);
            //roommate.EatFish();
            //roommate.EatMeat();
            //roommate.DrinkWater();


            //行为型
            //责任链
            //ApprovalHandler groupLeader = new GroupLeader("我是组长");
            //ApprovalHandler deptLeader = new DeptLeader("我是经理");
            //ApprovalHandler companyLeader = new CompanyLeader("我是老板");

            ////创建责任链关系
            //groupLeader.SetApprovor(deptLeader);
            //deptLeader.SetApprovor(companyLeader);

            ////创建请求
            //PurchaseRequest purchaseRequest = new(5,"买个作业本");
            //PurchaseRequest purchaseRequest1 = new(50, "买个键盘");
            //PurchaseRequest purchaseRequest2 = new(500, "买个办公桌");

            //groupLeader.Request(purchaseRequest);
            //groupLeader.Request(purchaseRequest1);
            //groupLeader.Request(purchaseRequest2);

            //命令
            //ICommand openCommand = new OpenCommand();
            //ICommand closeCommand = new CloseCommand();
            //ICommand changeChannelCommand = new ChangeChannelCommand();

            //Invoke invoke = new Invoke(openCommand, closeCommand, changeChannelCommand);

            //invoke.Open();
            //invoke.ChangeChannel(10);
            //invoke.ChangeChannel(22);
            //invoke.ChannelUndo();
            //invoke.ChannelUndo();
            //invoke.ChannelUndo();
            //invoke.Close();

            //迭代器
            //TVChannelMenu tVChannelMenu = new TVChannelMenu();
            //FilmMenu filmMenu = new FilmMenu();
            //MainMenu mainMenu = new MainMenu(tVChannelMenu, filmMenu);
            //mainMenu.PrintMenu();


            //IOC
            DB db = new DB(new SqlService());
            db.Add();


            IProductBL productBL = new ProductBL(new ProductDAL());

            var products = productBL.GetProducts();

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }


            Console.ReadLine();
        }
    }
}