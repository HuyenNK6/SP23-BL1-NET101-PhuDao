using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3
{
    internal class DongHo
    {
        //1. thuộc tính
        private int id;
        private string name;
        private double price;
        //2. ctor
        public DongHo()
        {

        }

        public DongHo(int id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        //3. Property
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
    
        //4. InThongTin()
        public void InThongTin()
        {
            Console.WriteLine($"Dong ho: {id}| {name}| {price}");
        }
    }
}
