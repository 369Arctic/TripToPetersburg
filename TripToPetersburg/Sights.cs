namespace TripToPetersburg
{
    public class Sights
    {
        public string Name { get; set; }
        public double Time { get; set; }
        public int Importance { get; set; }

        public Sights(string name, double time, int importance)
        {
            Name = name;
            Time = time;
            Importance = importance;
        }
    }
}
