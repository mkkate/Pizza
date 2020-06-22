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
    public class PicaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPice")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPice()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSvePice());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPicu/{picaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPica(int picaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiPicu(picaID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiPicu/{picaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePica(int picaID)
        {
            try
            {
                DataProvider.ObrisiPicu(picaID);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }
    }
}
