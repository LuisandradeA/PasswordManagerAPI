using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PasswordManagerAPI.Data;
using PasswordManagerAPI.Models;

namespace PasswordManagerV2.Controllers
{

	[ApiController]
	[Route("[controller]")]
	public class PasswordManagerController : Controller
    {
		
		private readonly ILogger<PasswordManagerController> _logger;
		private readonly DataContext _dataContext;


		public PasswordManagerController(ILogger<PasswordManagerController> logger, DataContext dataContext)
		{
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
			_dataContext = dataContext;
		}

        /// <summary>
        /// GET Student by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(SystemUser), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            //var user = await _dataContext.Users.FindAsync(id);

            var user = _dataContext.Users.Where(x => x.IdUser == id) ;

            if (user == null)
                return NotFound();

            return Ok(user);
        }

    }
}
