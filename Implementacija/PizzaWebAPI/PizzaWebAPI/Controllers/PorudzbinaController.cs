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
    public class PorudzbinaController : ControllerBase
    {
        #region Porudzbina
        [HttpGet]
        [Route("PreuzmiPorudzbine")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPorudzbine()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSvePorudzbine());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPorudzbinu/{porudzbinaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPorudzbinu(int porudzbinaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiPorudzbinu(porudzbinaID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPorudzbinu/{osobaID}/{voziloID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPorudzbinu([FromBody] PorudzbinaView p, int osobaID, int voziloID)
        {
            try
            {
                DataProvider.DodajPorudzbinu(p, osobaID, voziloID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiPorudzbinu/{porudzbinaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePorudzbinu(int porudzbinaID)
        {
            try
            {
                DataProvider.ObrisiPorudzbinu(porudzbinaID);
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
