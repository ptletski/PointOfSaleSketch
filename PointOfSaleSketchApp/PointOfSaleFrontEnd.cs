using System;
using System.Collections.Generic;

namespace PointOfSaleSketchApp
{
    public class PointOfSaleFrontEnd
    {
        public PointOfSaleFrontEnd()
        {
        }

        public async void SendOrder(List<SaleItem> saleItems)
        {
            PointOfSaleBackEnd backEnd = new PointOfSaleBackEnd();
            VerifiedOrder orderInformation = await backEnd.PlaceOrderAsync(saleItems);

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
