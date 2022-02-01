using CocheApplicationWeb.Model;

namespace CocheApplicationWeb.Repository
{
    public class RuedaRepository
    {

        private List<Rueda> Ruedas = new List<Rueda>();

        private MiDBContext MiDBContext;

        public RuedaRepository(MiDBContext miDBContext)
        {
            MiDBContext = miDBContext;
        }

        public List<Rueda> GetAll()
        {
            return MiDBContext.Ruedas.ToList();
        }

        public Rueda FindId(int id)
        {
            IEnumerable<Rueda> ruedas = MiDBContext.Ruedas.Where(r => r.id == id);

            switch(ruedas.LongCount())
            { 
                case 1:
                    return ruedas.First();

                case 0: throw new Exception("No encontrado");
                default:
                    throw new Exception("Error");
            }
        }

        public void Add(Rueda rueda)
        {
            if (rueda != null)
            {
                MiDBContext.Ruedas.Add(rueda);
                MiDBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Error");
            }
        } 

        public void Delete(int id)
        {
            Rueda r = FindId(id);
            MiDBContext.Ruedas.Remove(r);
            MiDBContext.SaveChanges();
        }

        public void Update(Rueda rueda)
        {
            if (rueda != null)
            {
                MiDBContext.Update(rueda);
                MiDBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Error");
            }
        }
    }
}
