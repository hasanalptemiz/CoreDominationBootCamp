namespace CoreDominationBootCamp.Models
{
    public class Category
    {
        public Category(int id, string name){
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
    }
    


}

