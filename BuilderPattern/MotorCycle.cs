using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.BuilderPattern
{
    // ConcreteBuilder:Motorcycle
    class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;
        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }
        public void StartUpOperations()
        {           
            //Starting with brandname
            product.Add(string.Format("Motorcycle Model name :{0}", this.brandName));
        }
        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }
        public void InsertWheels()
        {
            product.Add("2 wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("1 Headlights are added");
        }
        public void EndOperations()
        {
           //Nothing in this case
        }
        public Product GetVehicle()
        {
            return product;
        }
    }
}
