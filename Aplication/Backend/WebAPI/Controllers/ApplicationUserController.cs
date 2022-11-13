﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Entity.Context;
using Entity.Models;
using Entity.ViewModel;
using AutoMapper;
using WebAPI.Controllers;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Route("api/ApplicationUsers")]
    [ApiController]
    public class ApplicationUserController : ApiController
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private AthenticationContext _AthenticationContext;
        private IOptions<ApplicationSettings> _appSettings;

        public ApplicationUserController(UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager, 
            AthenticationContext athenticationContext, 
            IOptions<ApplicationSettings> appSettings)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _AthenticationContext = athenticationContext;
            _appSettings = appSettings;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Register")]
        //POST : /api/ApplicationUser/Register
        public async Task<ActionResult> PostApplicationUser([FromBody]ApplicationUserViewModel userModel)
        {
            
            try
            {
                var applicationUser =Mapper.Map<ApplicationUser>(userModel);
                var result = await _userManager.CreateAsync(applicationUser, userModel.Password);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        [Route("Login")]
        //POST:/api/ApplicationUser/Login
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserID", user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.Value.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
            }
            else
            {
                return BadRequest(new { message = "UserName or Passwords is incorrect" });
            }
        }
    }
}
