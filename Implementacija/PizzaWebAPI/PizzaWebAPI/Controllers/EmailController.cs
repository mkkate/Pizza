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
    public class EmailController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiEmailove")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetEmailovi()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveEmailove());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiEmail/{emailID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetEmail(int emailID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiEmail(emailID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiEmail/{emailID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteEmail(int emailID)
        {
            try
            {
                DataProvider.ObrisiEmail(emailID);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }
    }
}
