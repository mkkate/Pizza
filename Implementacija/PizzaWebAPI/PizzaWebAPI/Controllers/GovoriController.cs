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
    public class GovoriController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSveGovori")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSveGovori()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveGovori());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiGovori/{govoriID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGovori(int govoriID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiGovori(govoriID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiGovori/{govoriID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteGovori(int govoriID)
        {
            try
            {
                DataProvider.ObrisiGovori(govoriID);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }
    }
}
