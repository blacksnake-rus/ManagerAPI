using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// GET api/values
        /// </summary>
        /// <returns>Get array</returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        /// <summary>
        /// PUT api/values/5
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST
        ///     {
        ///        "String": "Some value"
        ///     }
        ///
        /// </remarks>
        /// <param name="id">Идентификатор</param>
        /// <param name="value">значение</param>
        /// <response code="201">Что-то про код 201</response>  
        /// <response code="400">Если-что-то произошло</response>  
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
