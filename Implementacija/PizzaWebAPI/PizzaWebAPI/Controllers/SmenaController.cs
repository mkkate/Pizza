using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaDatabaseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmenaController : ControllerBase
    {
        #region Smena
        [HttpGet]
        [Route("PreuzmiSmene")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSmene()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveSmene());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSmenu/{smenaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVozilo(int smenaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSmenu(smenaID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiSmenu/{smenaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteSmena(int smenaID)
        {
            try
            {
                DataProvider.ObrisiSmenu(smenaID);
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
