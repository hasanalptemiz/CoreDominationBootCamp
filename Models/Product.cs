namespace CoreDominationBootCamp.Models
{
    public class Product
    {
        public Product(int id, string name, decimal unitPrice, Category category ){
            ID = id;
            Name = name;
            UnitPrice = unitPrice;
            Category = category;
        }

        public int ID { get; private set; }
        public string Name { get; private set; }
        public decimal UnitPrice { get; private set; }
        public Category Category { get; private set; }
        
    }
    


}


