namespace lesson_0.Models
{
    public class Tank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int Maxvalue { get; set; }
        public int UnitID { get; set; }

        public Tank(int id, string name, int value, int max, int unitId)
        {
            Id = id;
            Name = name;
            Value = value;
            Maxvalue = max;
            UnitID = unitId;
        }
    }
}
