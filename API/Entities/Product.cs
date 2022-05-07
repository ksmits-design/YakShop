namespace API.Entities
{
    public class Herd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public string Sex { get; set; }
        public double Milk { get; set; }
        public bool Shaveable { get; set; }
        public string Brand { get; set; }
        public double DaysLastShaved { get; set; }
    }
}