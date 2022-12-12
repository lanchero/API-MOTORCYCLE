﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace Presentation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AgencyController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetAgencias()
        {
            var agencias = _service.AgencyService.GetAllAgencias(trackChanges: false);
            return Ok(agencias);
            
        }
        [HttpPost]
        public IActionResult PostAgency()
        {

            return Ok();
        }
    }
}
