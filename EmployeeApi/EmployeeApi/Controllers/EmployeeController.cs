﻿using EmployeeApi.Models;
using EmployeeApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region Property  
        private readonly IEmployeeService _employeeService;
        #endregion

        #region Constructor  
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        #endregion

        [HttpGet(nameof(GetEmployeeById))]
        public async Task<string> GetEmployeeById(int EmpID)
        {
            var result = await _employeeService.GetEmployeebyId(EmpID);
            return result;
        }
        [HttpGet(nameof(GetEmployeeDetails))]
        public async Task<Employee> GetEmployeeDetails(int EmpID)
        {
            var result = await _employeeService.GetEmployeeDetails(EmpID);
            return result;
        }
    }
}