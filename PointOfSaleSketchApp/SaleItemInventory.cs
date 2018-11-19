using System;
using System.Collections.Generic;

namespace PointOfSaleSketchApp
{//
    public class SaleItemInventory
    {
        private static readonly List<SaleItem> _Inventory;

        static SaleItemInventory()
        {
            _Inventory = new List<SaleItem>()
            {
                new SaleItem {Name="12 oz Pepsi", Price=1.75},
                new SaleItem {Name="11.5 oz Nacho Cheese Doritos", Price=1.98},
                new SaleItem {Name="8 oz Jack Links Beef Stick", Price=1.75},
                new SaleItem {Name="Miller Lite Beer 6 Pack 12 oz Bottle", Price=8.34},
                new SaleItem {Name="Pella Cheescake 124 oz", Price=12.45},
                new SaleItem {Name="Lays Potato Chips 64 oz", Price=4.57},
                new SaleItem {Name="Chlorox Wipes 120 count", Price=11.88},
                new SaleItem {Name="Dawn Dishwashing Detergent 48 oz", Price=4.66},
                new SaleItem {Name="Brillo Pads 12 count", Price=3.88},
                new SaleItem {Name="Bic Ballpoint Pens 6 pack", Price=4.12},
                new SaleItem {Name="Scotch Brand Tape 30 ft roll", Price=2.54},
                new SaleItem {Name="Schwebels White Bread Load", Price=1.99},
                new SaleItem {Name="Hostess Cupcakes 6 count", Price=5.88},
                new SaleItem {Name="Bounty Paper Towels 2 pack", Price=3.44}
            };
        }

        public static List<SaleItem> GenerateShoppingCart()
        {
            Random random = new Random();
            int numberOfItems = random.Next(1, 20);
            List<SaleItem> saleItems = new List<SaleItem>();

            for (int itemIndex = 0; itemIndex < numberOfItems; itemIndex++)
            {
                saleItems.Add(_Inventory[random.Next(0, 13)]);
            }

            return saleItems;
        }
    }
}
