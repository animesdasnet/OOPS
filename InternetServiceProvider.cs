using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internetServiceProvider
{
    public class InternetServiceProvider
    {
        private int _customerId;
        private string _customerName;
        private int _internetSpeed;
        public int BandWidths;
        public void CustomerDetails(int customerId, string customerName)
        {
            this._customerId = customerId;
            this._customerName = customerName;
        }
        public void CustomerDetails(int customerId, string customerName, int internetSpeed)
        {
            this._customerId = customerId;
            this._customerName = customerName;
            this._internetSpeed = internetSpeed;
        }
        public void PrimaryCustomerDetails()
        {
            Console.WriteLine("Customer ID: " + _customerId);
            Console.WriteLine("Customer Name: " + _customerName);
        }
        public void SecondaryCustomerDetails()
        {
            Console.WriteLine("Customer ID: " + _customerId);
            Console.WriteLine("Customer Name: " + _customerName);
            Console.WriteLine("Download Speed: " + _internetSpeed + " mbps");
        }
        public virtual void SpeedLimit()
        {
            Console.WriteLine("The speed limit is 20 mbps");
        }
    }
    public class ISpeed : InternetServiceProvider
    {
        public override void SpeedLimit()
        {
            base.SpeedLimit();
            Console.WriteLine("The speed limit can be extended from 20 mbps to 100 mbps");
        }
    }
    public abstract class BandWidths
    {
        public abstract void BandWidth();
    }
    public class ChangeBandWidths : BandWidths
    {
        public override void BandWidth()
        {
            Console.WriteLine("The bandwidths are fixed");
        }
    }

}