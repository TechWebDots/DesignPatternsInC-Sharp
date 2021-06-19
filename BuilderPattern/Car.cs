using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.BuilderPattern
{
    // ConcreteBuilder: Car
    class Car : IBuilder
    {
        private string brandName;
        private Product product;
        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }
        public void StartUpOperations()
        { 
            //Starting with brandname
            product.Add(string.Format("Car Model name :{0}", this.brandName));
        }
        public void BuildBody()
        {
            product.Add("This is a body of a Car");
        }
        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }
        public void AddHeadlights()
        {            
            product.Add("2 Headlights are added");
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
