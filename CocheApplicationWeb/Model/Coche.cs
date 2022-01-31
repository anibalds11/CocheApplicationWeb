namespace CocheApplicationWeb.Model
{
    public class Coche
    {
        public int id { get; set; }
        public string marcaCoche { get; set; }
        public Rueda rueda { get; set; }
        public Boolean motor { get; set; }

    }
}
