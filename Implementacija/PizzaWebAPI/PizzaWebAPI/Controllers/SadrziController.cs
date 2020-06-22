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
    public class SadrziController : ControllerBase
    {
        #region Sadrzi
        [HttpGet]
        [Route("PreuzmiSadrzaje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSadrzaje()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveSadrzaje());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSadrzaj/{sadrziID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSadrzaj(int sadrziID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSadrzaj(sadrziID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpPost]
        [Route("DodajSadrzaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSadrzaj([FromBody] SadrziView sadrzi)
        {
            try
            {
                DataProvider.DodajSadrzaj(sadrzi);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiSadrzaj/{sadrziID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteSadrzaj(int sadrziID)
        {
            try
            {
                DataProvider.ObrisiSadrzaj(sadrziID);
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
