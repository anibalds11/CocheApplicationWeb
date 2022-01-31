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

        public CocheController(CocheRepository cocheRepository)
        {
            this.cocheRepository = cocheRepository;
        }

        [HttpPost]
        public void CreateCoche(Coche coche)
        {

            try
            {
                cocheRepository.Add(coche);
            }
            catch
            {
                StatusCode(500);
            }

        }

        [HttpGet]
        public ActionResult<Object> GetCoches()
        {
            try
            {
                return Ok(cocheRepository.GetAll());
            }
            catch (Exception exp)
            {
                return StatusCode(404);
            }
        }

        [HttpGet]
        [Route("coche/{id}")]
        public ActionResult<Object> GetCoche(int id)
        {
            try
            {
                return Ok(cocheRepository.FindId(id));
            }
            catch (Exception exp)
            {
                return StatusCode(404);
            }
        }

        [HttpDelete]
        [Route("coche/{id}")]
        public void DeleteCoche(int id)
        {
            try
            {
                cocheRepository.Delete(id);
            }
            catch
            {
                StatusCode(500);
            }
        }

        [HttpPut]
        [Route("coche/{id}")]
        public void UpdateCoche(int id, Coche coche)
        {
            try
            {
                cocheRepository.Update(id, coche);
            }
            catch
            {
                StatusCode(500);
            }

        }
    }
}
