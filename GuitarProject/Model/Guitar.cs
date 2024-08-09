using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarProject.Model
{
    public class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price {  get; set; }
        public GuitarSpec Spec { get; set; }
        public Guitar(string serialNumber,double price,GuitarSpec spec) 
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        
        }
    }
}
