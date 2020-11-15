using Desafio.Domain.Interfaces;
using Desafio.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Desafio.UI.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        protected ISubscribe SubRepo;

        public SubscriptionsController(ISubscribe subRepo)
        {
            SubRepo = subRepo;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Subscribe sub)
        {
            try
            {
                if (await SubRepo.Exists(sub.Id) == false)
                    throw new Exception("Informação não encontrada na base de dados.");

                await SubRepo.Update(sub);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            try
            {
                var verification = await SubRepo.Get(id);

                if (verification == null)
                {
                    throw new Exception("Informação não encontrada na base de dados.");
                }

                await SubRepo.Delete(verification);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await SubRepo.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }
}
