using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PointOfSaleSketchApp
{
    public class PointOfSaleBackEnd
    {
        // Each HttpClient instance holds a connection pool, 
        // so you generally want to create one instance and reuse it. 
        private static HttpClient _transactionServer;

        static PointOfSaleBackEnd()
        {
            _transactionServer = new HttpClient();
        }

        public PointOfSaleBackEnd()
        {
            TransactionComplete = false;
        }

        public bool TransactionComplete { get; private set; }

        public async Task<VerifiedOrder> PlaceOrderAsync(List<SaleItem> saleItems)
        {
            try
            {
                var response = await _transactionServer.PostAsJsonAsync<List<SaleItem>>(
                        "http://localhost:3030/order",
                        saleItems);

                VerifiedOrder result = await response.Content.ReadAsAsync<VerifiedOrder>();

                Console.WriteLine($"Response Headers: {response.Headers}");
                Console.WriteLine($"Response Status Code: {response.StatusCode}");

                TransactionComplete = true; 

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }

            return null;
        }
    }
}
