
namespace VendingMachineAssignment
{
    public class GoodsItem
    {
        public class Items
        {
            public string Product { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public Items(string product, double price, int quantity)
            {
                Product = product;
                Price = price;
                Quantity = quantity;
            }
        }
    }
}
