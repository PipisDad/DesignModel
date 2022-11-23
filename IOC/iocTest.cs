using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.IOC
{
    public interface IDataBase
    {
        void Add();
    }

    public class Oracle : IDataBase
    {
        public void Add()
        {
            Console.WriteLine("使用 Oracle 数据库增加了数据");
        }
    }

    public class SqlService : IDataBase
    {
        public void Add()
        {
            Console.WriteLine("使用 SqlService 数据库增加了数据");
        }
    }

    public class DB
    {
        private IDataBase db;
        public DB(IDataBase db)
        {
            this.db = db;
        }
        public void Add()
        {
            db.Add();
        }
    }


    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public interface IProductDAL
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProducts(string name);
    }

    public class ProductDAL:IProductDAL
    {
        private readonly List<Product> _products;

        public ProductDAL()
        {
            _products = new List<Product>
            {
            new Product { Id = Guid.NewGuid(), Name= "iPhone 9",
                          Description = "iPhone 9 mobile phone" },
            new Product { Id = Guid.NewGuid(), Name= "iPhone X",
                          Description = "iPhone X mobile phone" }
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public IEnumerable<Product> GetProducts(string name)
        {
            return _products
                .Where(p => p.Name.Contains(name))
                .ToList();
        }
    }

    public interface IProductBL
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProducts(string name);
    }

    public class ProductBL:IProductBL
    {
        private readonly IProductDAL _productDAL;  

        public ProductBL(IProductDAL productDAL)
        {
            this._productDAL = productDAL;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productDAL.GetProducts();
        }

        public IEnumerable<Product> GetProducts(string name)
        {
            return _productDAL.GetProducts(name);
        }
    }
}
