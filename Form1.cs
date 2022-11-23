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
            //������

            //���󹤳�

            //WoodDesk woodDesk = new WoodDesk();
            //woodDesk.CreateMadeby();
            //woodDesk.CreateType();


            //������
            //AnimalDirector animalDirector = new AnimalDirector(new CatBuilder());
            //Animal animal = animalDirector.BuilderAnimal();
            //Console.WriteLine(animal.Sound);
            //Console.WriteLine(animal.Color);

            //��������
            //FactoryWood factoryWood = new FactoryWood();
            //DesignModel.FactoryMethod.MadeBy madeBy = factoryWood.CreateMadeBy();


            //ԭ�ͷ���
            //PersonInfo personInfo = new PersonInfo("�ֻ�");
            //personInfo.SetSchoolInfo("˫Ѽɽ��ѧ", "����");
            //personInfo.SetBaseInfo("��",18);
            //personInfo.PrintInfo();


            //����ģʽ
            //var temp = Singleton.Instance;


            //�ṹ
            //������

            //Chicken chicken = new Chicken();
            //chicken.Talk();
            //chicken.Move();

            //С����ģ�⹷��
            //Dog dog = new Dog();
            //IAnimal animal = new DogAdapter(dog);
            //animal.Talk();
            //animal.Move();

            //�Ž�
            //DesignModel.Structural.Color white = new White();
            ////��ɫ�ĳ�����
            //Shape square = new Square();
            //square.SetColor(white);
            //square.Draw();

            //��ɫ������
            //Shape rectange = new DesignModel.Structural.Rectangle();
            //rectange.SetColor(white);
            //rectange.Draw();

            //���
            //Folder folder = new ChildrenFolder();
            //folder.Open();
            //folder.Add(new ChildrenFolder());
            //folder.Remove(new ChildrenFolder());

            //Folder text = new Text_1();
            //text.Open();
            //text.Add(folder);
            //text.Remove(folder);


            //װ����
            //Component component = new Cat();
            //var componentBlack = new WhiteDecorator(component);
            //Component componentWing = new WingDecorator(componentBlack);
            //componentWing.Display();

            //���ģʽ
            //Facade facade = new Facade();
            //facade.Method_A();
            //facade.Method_B();

            //��Ԫ
            //DeviceFatory deviceFatory = DeviceFatory.Instance;
            //Device camera = deviceFatory.GetDevice("Computer");
            //Device camera2 = deviceFatory.GetDevice("Computer");
            //Console.WriteLine($"�Ƿ����:{camera == camera2}");
            //camera.Display();
            //camera2.Display();

            //����
            //Cat_2 cat = new Cat_2("����");
            //Roommate roommate = new Roommate(cat);
            //roommate.EatFish();
            //roommate.EatMeat();
            //roommate.DrinkWater();


            //��Ϊ��
            //������
            //ApprovalHandler groupLeader = new GroupLeader("�����鳤");
            //ApprovalHandler deptLeader = new DeptLeader("���Ǿ���");
            //ApprovalHandler companyLeader = new CompanyLeader("�����ϰ�");

            ////������������ϵ
            //groupLeader.SetApprovor(deptLeader);
            //deptLeader.SetApprovor(companyLeader);

            ////��������
            //PurchaseRequest purchaseRequest = new(5,"�����ҵ��");
            //PurchaseRequest purchaseRequest1 = new(50, "�������");
            //PurchaseRequest purchaseRequest2 = new(500, "����칫��");

            //groupLeader.Request(purchaseRequest);
            //groupLeader.Request(purchaseRequest1);
            //groupLeader.Request(purchaseRequest2);

            //����
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

            //������
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