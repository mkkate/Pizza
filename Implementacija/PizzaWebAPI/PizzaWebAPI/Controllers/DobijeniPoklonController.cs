using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaDatabaseAccess;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DobijeniPoklonController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPoklone")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPoklone()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSvePoklone());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPoklon/{poklonID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPoklon(int poklonID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiPoklon(poklonID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiPoklon/{poklonID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePoklon(int poklonID)
        {
            try
            {
                DataProvider.ObrisiPoklon(poklonID);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }
    }
}
