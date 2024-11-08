using System.Text.Json;
namespace xxxxxxxxx
{
    class vain
    {
        public static void Main(string[] args)
        {
            C.Buyer chel1 = new C.Buyer("JoJo", "12345");
            C.Product product1 = new C.Product(33, "corndog");
            var purchase = new Dictionary<object, object>()
            {
                {chel1.Name, product1.product_name}
            };
            string jsonString = JsonSerializer.Serialize(chel1);
            Console.WriteLine($"JSON файл Описание покупателя: {jsonString}");
            string jsonString2 = JsonSerializer.Serialize(product1);
            Console.WriteLine($"JSON файл Опсание товара: {jsonString2}");
            string jsonString3 = JsonSerializer.Serialize(purchase);
            Console.WriteLine($"JSON файл который хранить информацию о покупке: {jsonString3}");

        }
    
    
    }
}
namespace C
{
    class Buyer
    {
        public string Name;
        string card_id;
        public Buyer(string name, string card_id)
        {
            Name = name;
            this.card_id = card_id; 
        }


    }
    class Product
    {
        int quantity;
        public string product_name;
        public Product(int quantity, string product_name)
        {
            this.quantity = quantity;
            this.product_name = product_name;       
        }
    }

}
namespace b
{
    class product
    {
        string name;
        int price;
        string description;

    }
    class addresses
    {
        string type;
        string address;
    }
    class shop
    {
        string category;
        List<string> products = new List<string>();

    }
    class order
    {
        int id;
        List<string> items = new List<string>();
        int total;
    }
    class user
    {
        string name;
        string email;
        int purchases;
    }
    class cart
    {
        List<string> cart_product = new List<string>();
    }
    class shipping
    {
        string method;
        int price;
        int estimated_days;
    }
    class payment
    {
        string method;
        string status;
    
    }
    class reviews
    {
        string product;
        int rating;
        string coment;
    }
    class discounts
    {
        string product;
        string discount;
    }


}
