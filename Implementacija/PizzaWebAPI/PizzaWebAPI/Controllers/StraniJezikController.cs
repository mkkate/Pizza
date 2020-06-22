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
    public class StraniJezikController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiJezike")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetJezike()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveJezike());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiJezik/{jezikID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetJezik(int jezikID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiJezik(jezikID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiJezik/{jezikID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteJezik(int jezikID)
        {
            try
            {
                DataProvider.ObrisiJezik(jezikID);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }
    }
}
