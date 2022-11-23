using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Behavioral
{
    //请求类
    public class PurchaseRequest
    {
        private int money;
        private string reason;

        public PurchaseRequest(int money, string reason)
        {
            this.money = money;
            this.reason = reason;
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }
    }

    //审批者类
    public abstract class ApprovalHandler
    {
        protected ApprovalHandler handler;//上级处理对象
        private string name;//审批者

        public ApprovalHandler( string name)
        {
            this.name = name;
        }
        public void SetApprovor(ApprovalHandler handler)
        {
            this.handler = handler;
        }

        public abstract void Request(PurchaseRequest purchaseRequest);
    }
    public class GroupLeader : ApprovalHandler
    {
        public GroupLeader(string name) : base(name)
        {
        }

        public override void Request(PurchaseRequest purchaseRequest)
        {
            if(purchaseRequest.Money<10)
            {
                Console.WriteLine($"组长审批了：{purchaseRequest.Money},理由是:{purchaseRequest.Reason}");
            }
            else
            {
                this.handler.Request(purchaseRequest);
            }
        }
    }

    public class DeptLeader : ApprovalHandler
    {
        public DeptLeader(string name) : base(name)
        {
        }

        public override void Request(PurchaseRequest purchaseRequest)
        {
            if (purchaseRequest.Money < 100)
            {
                Console.WriteLine($"经理审批了：{purchaseRequest.Money},理由是:{purchaseRequest.Reason}");
            }
            else
            {
                this.handler.Request(purchaseRequest);
            }
        }
    }
    public class CompanyLeader : ApprovalHandler
    {
        public CompanyLeader(string name) : base(name)
        {
        }

        public override void Request(PurchaseRequest purchaseRequest)
        {
            Console.WriteLine($"老板审批了：{purchaseRequest.Money},理由是:{purchaseRequest.Reason}");
        }
    }

    internal class ChainOfResponsibility
    {
    }
}
