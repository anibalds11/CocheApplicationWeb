using CocheApplicationWeb.Model;

namespace CocheApplicationWeb.Repository
{
    public class CocheRepository
    {

        private List<Coche> Coches = new List<Coche>();

        private MiDBContext MiDBContext;

        public CocheRepository(MiDBContext miDBContext)
        {
            MiDBContext = miDBContext;
        }

        public List<Coche> GetAll()
        {
            return MiDBContext.Coches.ToList();
        }

        public Coche FindId(int id)
        {
            IEnumerable<Coche> coches = MiDBContext.Coches.Where(r => r.id == id);

            switch (coches.LongCount())
            {
                case 1:
                    return coches.First();

                case 0: throw new Exception("No encontrado");
                default:
                    throw new Exception("Error");
            }
        }

        public void Add(Coche coche)
        {
            if (coche != null && id != null)
            {
                MiDBContext.Coches.Add(coche);
                MiDBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Error");
            }

        }

        public void Delete(int id)
        {
            Coche r = FindId(id);
            MiDBContext.Coches.Remove(r);
            MiDBContext.SaveChanges();
        }

        public void Update(int id,Coche coche)
        {
            if (coche != null && id != null)
            {
                Coche cocheC = FindId(id);
                cocheC.marcaCoche = coche.marcaCoche;
                cocheC.motor = coche.motor;
                cocheC.rueda = coche.rueda;
                MiDBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Error");
            }
        }
    }
}
