namespace lesson_0.Models
{
    public class Factory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public Factory(int id, string name, string desc)
        {
            Id = id;
            Name = name;
            Description = desc;
        }
    }
}
