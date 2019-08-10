using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NutritionControl.BLL.Concrete;
using NutritionControl.DAL;
using NutritionControl.DAL.Concrete.Entities;
using static NutritionControl.Helpers.Error;

namespace NutritionControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {

        private readonly ApplicationDbContext _appDbContext;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public AccountsController(UserManager<User> userManager, IMapper mapper, ApplicationDbContext appDbContext)
        {
            _userManager = userManager;
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

        // POST api/accounts
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userIdentity = _mapper.Map<User>(model);

            var result = await _userManager.CreateAsync(userIdentity, model.Password);

            if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

            await _appDbContext.AuthorizedUsers.AddAsync(new AuthorizedUser { IdentityId = userIdentity.Id});
            await _appDbContext.SaveChangesAsync();

            return new OkObjectResult("Account created");
        }




    }
}