using CocheApplicationWeb.Model;
using CocheApplicationWeb.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CocheApplicationWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CocheController : ControllerBase
    {

        private CocheRepository cocheRepository;
        private RuedaRepository ruedaRepository;
        private MiDBContext _context;

        public CocheController(CocheRepository cocheRepository, RuedaRepository ruedaRepository, MiDBContext context)
        {
            this.cocheRepository = cocheRepository;
            this.ruedaRepository = ruedaRepository;
            this._context = context;
        }

        [HttpPost]
        public void CreateCoche(Coche coche)
        {

            using var transaction = this._context.Database.BeginTransaction();
            try
            {
                cocheRepository.Add(coche);
            }
            catch
            {
                transaction.Rollback();
                StatusCode(500);
            }

        }

        [HttpGet]
        public ActionResult<Object> GetCoches()
        {
            using var transaction = this._context.Database.BeginTransaction();
            try
            {
                List<Coche> coches = cocheRepository.GetAll();
                transaction.Commit();
                   return Ok(coches);
            }
            catch (Exception exp)
            {
                transaction.Rollback();
                return StatusCode(404);
            }
        }

        [HttpGet]
        [Route("coche/{id}")]
        public ActionResult<Object> GetCoche(int id)
        {
            using var transaction = this._context.Database.BeginTransaction();
            try
            {
                return Ok(cocheRepository.FindId(id));
            }
            catch (Exception exp)
            {
                transaction.Rollback();
                return StatusCode(404);
            }
        }

        [HttpDelete]
        [Route("coche/{id}")]
        public void DeleteCoche(int id)
        {
            using var transaction = this._context.Database.BeginTransaction();
            try
            {
                cocheRepository.Delete(id);
            }
            catch
            {
                transaction.Rollback();
                StatusCode(500);
            }
        }

        [HttpPut]
        [Route("coche/{id}")]
        public void UpdateCoche(Coche coche)
        {
            using var transaction = this._context.Database.BeginTransaction();
            try
            {
                cocheRepository.Update(coche);
            }
            catch
            {
                transaction.Rollback();
                StatusCode(500);
            }

        }
    }
}
