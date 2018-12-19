using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace PointOfSaleSketchApp
{
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

                Console.WriteLine("Main: Order Done");
            }

            Console.WriteLine("Main: Exit");
        }
    }
}
