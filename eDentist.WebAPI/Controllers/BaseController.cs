﻿using eDentist.WebAPI.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, Tsearch> : ControllerBase
    {
        private readonly IBaseService<T, Tsearch> _service;
        public BaseController(IBaseService<T, Tsearch> service)
        {
            _service = service;
        }
        [Authorize]
        [HttpGet]
        public async Task<List<T>> Get([FromQuery] Tsearch search)
        {
            return await _service.Get(search);
        }
        [Authorize]
        [HttpGet("{ID}")]
        public async Task<T> GetById(int ID)
        {
            return await _service.GetById(ID);
        }
    }
}
