using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PointOfSaleSketchApp
{
    public class PointOfSaleFrontEnd
    {
        private PointOfSaleBackEnd _backEnd;

        public PointOfSaleFrontEnd()
        {
            _backEnd = new PointOfSaleBackEnd();
        }

        public async void SendOrder(List<SaleItem> saleItems)
        {
            PointOfSaleBackEnd backEnd = new PointOfSaleBackEnd();

            Console.WriteLine("FrontEnd: Started Async Work");
            Task<VerifiedOrder> orderTask = backEnd.PlaceOrderAsync(saleItems);

            Console.WriteLine("FrontEnd: Doing Other Work");
            Thread.Sleep(1000);
            Console.WriteLine("FronEnd: Retrieving Async Work");

            VerifiedOrder orderInformation = await orderTask;

            if (orderInformation != null)
            {
                Console.WriteLine($"Order Verfied: ID {orderInformation.OrderId}");
                Console.WriteLine($"Order Verfied: Total ${orderInformation.OrderTotal}");
            }
            else
            {
                Console.WriteLine("Error Placing Order With Service");
            }
        }
    }
}
