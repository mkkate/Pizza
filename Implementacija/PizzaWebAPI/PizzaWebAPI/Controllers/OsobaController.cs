using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaDatabaseAccess;
using PizzaDatabaseAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OsobaController : ControllerBase
    {
        #region Osoba
        [HttpGet]
        [Route("PreuzmiOsobe")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetOsobe()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveOsobe());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiOsobu/{osobaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetOsobu(int osobaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiOsobu(osobaID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpPost]
        [Route("DodajOsobu/{voziloID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddOsobu([FromBody] OsobaView o, int voziloID)
        {
            try
            {
                DataProvider.DodajOsobu(o, voziloID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiOsobu/{osobaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteOsobu(int osobaID)
        {
            try
            {
                DataProvider.ObrisiOsobu(osobaID);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }
        #endregion

    }
}
