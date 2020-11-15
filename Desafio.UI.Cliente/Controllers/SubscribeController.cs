using Desafio.Domain.Interfaces;
using Desafio.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Desafio.UI.Cliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        protected ISubscribe SubRepo;
        public SubscribeController(ISubscribe subRepo)
        {
            SubRepo = subRepo;
        }

        [HttpPost("subscription")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SubScription([FromBody]Subscribe sub)
        {
            try
            {
                var verification = await SubRepo.Verification(sub.Email);

                if (verification != null)
                    throw new Exception("Você já se inscreveu.");

                sub.DtCreate = DateTime.Now;
                await SubRepo.Insert(sub);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(400,ex.Message);
            }
        }


    }
}
