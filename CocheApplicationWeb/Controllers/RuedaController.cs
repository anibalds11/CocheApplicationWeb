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

            public RuedaController(RuedaRepository ruedaRepository)
            {
                this.ruedaRepository = ruedaRepository;
            }

            [HttpPost]
            public void CreateRueda(Rueda rueda)
            {
                try
                {
                    ruedaRepository.Add(rueda);
                }
                catch
                {
                    StatusCode(500);
                }
            }

            [HttpGet]
            public ActionResult<Object> GetRuedas()
            {
                try
                {
                 return Ok(ruedaRepository.GetAll());
                }
                catch(Exception exp)
                {
                    return StatusCode(500);
                }
            }

            [HttpGet]
            [Route("rueda/{id}")]
            public ActionResult<Object> GetRueda(int id)
            {
            try
            {
                return Ok(ruedaRepository.FindId(id));
            }
            catch (Exception exp)
            {
                return StatusCode(500);
            }
        }

            [HttpDelete]
            [Route("rueda/{id}")]
            public void DeleteRueda(int id)
            {
                try
                {
                    ruedaRepository.Delete(id);
                }
                catch
                {
                    StatusCode(500);
                }
        }

            [HttpPut]
            [Route("rueda/{id}")]
            public void UpdateRueda(int id,Rueda rueda)
            {
                try
                {
                    ruedaRepository.Update(id, rueda);
                }
                catch
                {
                    StatusCode(500);
                }
        }

        }
    }
