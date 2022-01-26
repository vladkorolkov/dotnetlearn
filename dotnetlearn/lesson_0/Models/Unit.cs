namespace lesson_0.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FactoryId { get; set; }

        public Unit(int id, string name, int factoryId )
        {
            Id = id;
            Name = name;    
            FactoryId = factoryId;  
        }


    }
}
