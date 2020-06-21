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
    public class BrTelefonaController : ControllerBase
    {
        #region Porudzbina
        [HttpGet]
        [Route("PreuzmiBrojeveTelefona")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBrojeveTelefona()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveBrojeveTelefona());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiBrojTelefona/{brtelID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBrojTelefona(int brtelID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiBrojTelefona(brtelID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpPost]
        [Route("DodajBrojTelefona/{osobaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddBrojTelefona([FromBody] BrTelefonaView brtel, int osobaID)
        {
            try
            {
                DataProvider.DodajBrojTelefona(brtel, osobaID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiBrojTelefona/{brtelID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteBrojTelefona(int brtelID)
        {
            try
            {
                DataProvider.ObrisiBrojTelefona(brtelID);
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
