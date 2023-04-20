using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    public class Tovar
    {
		private string name;
		private string characteristic;
		private string info;
		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public string Info
		{
			get { return info; }
			set { info = value; }
		}

		public string Сharacteristic
        {
			get { return characteristic; }
			set { characteristic = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public Tovar() { Name = "name1"; Сharacteristic = "Сharacteristic1"; Info = "info1"; Price = 100;}

		public Tovar(string name, string characteristic, string info, double price)
		{
			this.name = name;
			this.characteristic = characteristic;
			this.info = info;
			this.price = price;
		}

        public override string ToString()
        {
			return "Name = " + Name + " Сharacteristic = " + Сharacteristic + " Info = " + Info;
        }
    }
}
