using CocheApplicationWeb.Model;
using CocheApplicationWeb.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CocheApplicationWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RuedaController : ControllerBase
    {

        private RuedaRepository ruedaRepository;
        private MiDBContext _context;

        public RuedaController(RuedaRepository ruedaRepository, MiDBContext context)
        {
            this.ruedaRepository = ruedaRepository;
            this._context = context;
        }

        [HttpPost]
        public void CreateRueda(Rueda rueda)
        {
            using var transaction = this._context.Database.BeginTransaction();
            try
            {
                ruedaRepository.Add(rueda);
            }
            catch
            {
                transaction.Rollback();
                StatusCode(500);
            }
        }

        [HttpGet]
        public ActionResult<Object> GetRuedas()
        {
            using var transaction = this._context.Database.BeginTransaction();
            try
            {
                return Ok(ruedaRepository.GetAll());
            }
            catch (Exception exp)
            {
                transaction.Rollback();
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("rueda/{id}")]
        public ActionResult<Object> GetRueda(int id)
        {
            using var transaction = this._context.Database.BeginTransaction();
            try
            {
                return Ok(ruedaRepository.FindId(id));
            }
            catch (Exception exp)
            {
                transaction.Rollback();
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("rueda/{id}")]
        public void DeleteRueda(int id)
        {
            using var transaction = this._context.Database.BeginTransaction();
            try
            {
                ruedaRepository.Delete(id);
            }
            catch
            {
                transaction.Rollback();
                StatusCode(500);
            }
        }

        [HttpPut]
        public void UpdateRueda(Rueda rueda)
        {
            using var transaction = this._context.Database.BeginTransaction();
            try
            {
                ruedaRepository.Update(rueda);
            }
            catch
            {
                transaction.Rollback();
                StatusCode(500);
            }
        }

    }
}
