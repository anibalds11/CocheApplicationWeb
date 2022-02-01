using System.ComponentModel.DataAnnotations.Schema;

namespace CocheApplicationWeb.Model
{
    public class Rueda
    {

        public int id{ get; private set; }
        public string marcaRueda { get; set; }
        public Boolean movimiento { get; set; }

        public Rueda(int id,string marcaRueda, bool movimiento)
        {
            this.id = id;
            this.marcaRueda = marcaRueda;
            this.movimiento = movimiento;
        }
    }
}
