namespace lesson_0.Models
{
    public class Unit
    {
        public int id { get; set; }
        public string name { get; set; }
        public int factoryId { get; set; }

        public Unit(int Id, string Name, int FactoryId )
        {
            id = Id;
            name = Name;    
            factoryId = FactoryId;  
        }
    }
}
