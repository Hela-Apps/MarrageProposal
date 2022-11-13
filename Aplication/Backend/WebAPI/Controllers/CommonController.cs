﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.CommonDomain;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ApiController
    {
        private readonly ICommonService _commonService;
        public CommonController(ICommonService commonService)
        {
            _commonService = commonService;
        }

        

        [HttpGet]
        [Route("GetAllDistricts")]
        public async Task<IActionResult> GetAllDistrict()
        {
            try
            {
                return Ok(await _commonService.GetAllDistricts());
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }

        [HttpGet]
        [Route("GetAllCitiesbyDistrictId")]
        public async Task<IActionResult> GetAllCitiesbyDistrictId(int districtId)
        {
            try
            {
                return Ok(await _commonService.GetAllCitiesbyDistrictId(districtId));
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }
       
    }
}
