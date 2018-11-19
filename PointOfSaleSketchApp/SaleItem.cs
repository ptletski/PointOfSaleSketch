using System;

namespace PointOfSaleSketchApp
{//
    public class SaleItem
    {
        private double _price;
        private string _name;

        public SaleItem()
        {
        }

        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
    }
}
