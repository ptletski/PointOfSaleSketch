using System;
using System.Threading;

namespace PointOfSaleSketchApp
{//
    public class PointOfSaleMain
    {
        public PointOfSaleMain()
        {
        }

        public void Execute()
        {
            Console.WriteLine("Be sure to start up the Web service project PointOfSaleService in the Project Directory.");
            Console.ReadKey();

            PointOfSaleFrontEnd frontEnd = new PointOfSaleFrontEnd();

            while (Console.KeyAvailable == false)
            {
                Console.WriteLine("Main: Placing Order");

                frontEnd.SendOrder(SaleItemInventory.GenerateShoppingCart());

                Console.WriteLine("Main: Waiting");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Main: Exit");
        }
    }
}
