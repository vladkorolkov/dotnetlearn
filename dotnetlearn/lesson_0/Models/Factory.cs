namespace lesson_0.Models
{
    public class Factory
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }


        public Factory(int Id, string Name, string Desc)
        {
            id = Id;
            name = Name;
            description = Desc;
        }
    }
}
