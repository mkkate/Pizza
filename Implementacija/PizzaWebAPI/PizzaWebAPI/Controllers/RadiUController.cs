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
    public class RadiUController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSveRadiU")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSveRadiU()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveRadiU());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiRadiU/{radiUID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRadiU(int radiUID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiRadiU(radiUID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiRadiU/{radiUID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteRadiU(int radiUID)
        {
            try
            {
                DataProvider.ObrisiRadiU(radiUID);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }
    }
}
