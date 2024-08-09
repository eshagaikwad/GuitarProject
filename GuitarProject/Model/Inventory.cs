using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarProject.Model
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        { 
         guitars =new List<Guitar>();
        
        }

        public void AddGuitarToInventory(string serialNumber, double price, GuitarSpec spec)
        { 
            Guitar guitar =new Guitar(serialNumber,price,spec);
            guitars.Add(guitar);
        
        }

        public Guitar getGuitarBySerialNumber(string serialNumber)
        {
            return guitars.FirstOrDefault(guitar => guitar.SerialNumber == serialNumber);
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        { 
            List<Guitar> MatchingGuitar = new List<Guitar>();


            foreach (var guitar in guitars)
            {
                if (guitar.Spec.Matches(searchSpec))
                { 
                MatchingGuitar.Add(guitar);
                
                }
            }
            return MatchingGuitar;



        }
    }

}
