using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using PizzaDatabaseAccess;
using PizzaDatabaseAccess.DTOs;

namespace PizzaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoziloController : ControllerBase
    {
        #region Vozilo
        [HttpGet]
        [Route("PreuzmiVozila")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVozila()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSvaVozila());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiVozilo/{voziloID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVozilo(int voziloID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiVozilo(voziloID));
            }
            catch(Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiVozilo/{voiloID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteVozilo(int voziloID)
        {
            try
            {
                DataProvider.ObrisiVozilo(voziloID);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }
        #endregion

        #region VoziloBicikl
        [HttpPost]
        [Route("DodajVoziloBicikl")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddVoziloBicikl([FromBody]VoziloBiciklView vb)
        {
            try
            {
                DataProvider.DodajVoziloBicikl(vb);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion

        #region VoziloAutomobil
        [HttpPost]
        [Route("DodajVoziloAutomobil")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddVoziloAutomobil([FromBody] VoziloAutomobilView va)
        {
            try
            {
                DataProvider.DodajVoziloAutomobil(va);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion

        #region VoziloSkuter
        [HttpPost]
        [Route("DodajVoziloBicikl")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddVoziloSkuter([FromBody] VoziloSkuterView vs)
        {
            try
            {
                DataProvider.DodajVoziloSkuter(vs);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
