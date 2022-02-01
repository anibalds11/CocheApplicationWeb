namespace CocheApplicationWeb.Model
{
    public class Coche
    {
        public int id { get; set; }
        public string marcaCoche { get; set; }
        public virtual Rueda rueda { get; set; }
        public Boolean motor { get; set; }

        public Coche(int id, string marcaCoche, Rueda rueda, bool motor)
        {
            this.id = id;
            this.marcaCoche = marcaCoche;
            this.rueda = rueda;
            this.motor = motor;
        }

        public Coche()
        {
        }
    }
}
