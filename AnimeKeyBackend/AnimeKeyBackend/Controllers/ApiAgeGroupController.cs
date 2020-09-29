using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeKeyBackend.Services;
using BL.Infrastructure;
using BL.Secuirty;
using BL.Security;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.APIModels;
using static BL.SharedCS.Enumrations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimeKeyBackend.Controllers
{
    [Route("api/[controller]")]
    public class ApiAgeGroupController : Controller
    {
        private readonly IUnitOfWork _uow;
        private readonly ISecurity _security;
        private readonly IAuthenticateService _authService;
        private readonly IHostingEnvironment _env;

        public ApiAgeGroupController(IUnitOfWork uow, ISecurity Security, IAuthenticateService authService, IHostingEnvironment env)
        { _uow = uow; _security = Security; _env = env; _authService = authService; }

        [HttpGet, Route("GetAgeGroups")]
        public IActionResult Get()
        {
            try
            {
                Request.Headers.TryGetValue("token", out var token);

                var user = _authService.GetUserByToken(token);
                if (user == null)
                { return BadRequest("User not found"); }
                if (!UserAccountMannager.HasPermission(_uow, _security, AppSession.CurrentUser.Id, EN_Screens.AgeGroup, EN_Permissions.View))
                {
                    return Ok(new ResponseModel
                    {
                        ModelState = EN_ModelState.NotValid,
                        Status = EN_ResponseStatus.Faild,
                        Message = "User has no permission to View AgeGroup!!",
                        Data = new { }
                    });
                }
                var ageGroups = _uow.AgeGroupRepository.GetMany(ent => ent.IsActive && !ent.IsDeleted).ToHashSet();
                return Ok(new ResponseModel
                {
                    ModelState = EN_ModelState.Success,
                    Status = EN_ResponseStatus.Success,
                    Message = "Done",
                    Data = ageGroups

                });
            }
            catch (Exception ex)
            { return BadRequest("Error: " + ex.Message); }
        }


        [HttpGet("{id}"), Route("GetAgeGroupById")]
        public IActionResult Get(long id)
        {
            try
            {
                var entity = new AgeGroup();
                if (id != default)
                {
                    Request.Headers.TryGetValue("token", out var token);

                    var user = _authService.GetUserByToken(token);
                    if (user == null)
                    { return BadRequest("User not found"); }
                    //Check User Permission For this Page
                    if (!UserAccountMannager.HasPermission(_uow, _security, AppSession.CurrentUser.Id, EN_Screens.AgeGroup, EN_Permissions.View))
                    {

                        return Ok(new ResponseModel
                        {
                            ModelState = EN_ModelState.NotValid,
                            Status = EN_ResponseStatus.Faild,
                            Message = "User has no permission to get AgeGroup !!",
                            Data = new { }
                        });
                    }

                    entity = _uow.AgeGroupRepository.GetById(id);
                    if (entity == null || entity.IsDeleted)
                    {
                        return Ok(new ResponseModel
                        {
                            ModelState = EN_ModelState.NotFound,
                            Status = EN_ResponseStatus.Faild,
                            Message = "This Item Is Not Found!!",
                            Data = new { }
                        });
                    }
                    else
                    {
                        return Ok(new ResponseModel
                        {
                            ModelState = EN_ModelState.Success,
                            Status = EN_ResponseStatus.Success,
                            Message = "Done",
                            Data = entity

                        });
                    }

                }
                else
                {
                    return Ok(new ResponseModel
                    {
                        ModelState = EN_ModelState.NotValid,
                        Status = EN_ResponseStatus.Faild,
                        Message = "Id is empty!!",
                        Data = entity

                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }

        [HttpPost, Route("AddAgeGroup")]
        public IActionResult Post([FromBody]AgeGroup entity)
        {
            try
            {
                Request.Headers.TryGetValue("token", out var token);

                var user = _authService.GetUserByToken(token);
                if (user == null)
                { return BadRequest("User not found"); }
                if (!UserAccountMannager.HasPermission(_uow, _security, AppSession.CurrentUser.Id, EN_Screens.AgeGroup, EN_Permissions.Create))
                {
                    {
                        return Ok(new ResponseModel
                        {
                            ModelState = EN_ModelState.NotValid,
                            Status = EN_ResponseStatus.Faild,
                            Message = "User has no permission to create AgeGroup!!",
                            Data = new { }
                        });
                    }
                }

                if (entity.Id == default)
                {
                    entity.Code = UIHelper.GeneratCode(EN_Screens.AgeGroup, _uow);
                    if (string.IsNullOrEmpty(entity.CountryEnglishName)) { entity.CountryEnglishName = entity.CountryArabicName; }

                    entity.CreationDate = DateTime.Now;
                    entity.CreatedBy = AppSession.CurrentUser.Id;
                    //Re-ValidateModel
                    ModelState.Clear();
                    TryValidateModel(entity);
                    if (ModelState.IsValid)
                    { _uow.AgeGroupRepository.Add(entity); }
                }
                else
                {
                    entity.ModificationDate = DateTime.Now;
                    entity.ModifiedBy = AppSession.CurrentUser.Id;


                    //Re-ValidateModel
                    ModelState.Clear();
                    TryValidateModel(entity);
                    if (ModelState.IsValid) { _uow.AgeGroupRepository.Update(entity); }
                }
                _uow.Save();

                return Ok(new ResponseModel
                {
                    ModelState = EN_ModelState.Success,
                    Status = EN_ResponseStatus.Success,
                    Message = "Done",
                    Data = entity

                });
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }

        }


        [HttpDelete("{id}"), Route("DeleteAgeGroup")]
        public IActionResult Delete(long id)
        {
            Request.Headers.TryGetValue("token", out var token);

            var user = _authService.GetUserByToken(token);
            if (user == null)
            { return BadRequest("User not found"); }
            //Check User Permission For this Page
            if (!UserAccountMannager.HasPermission(_uow, _security, AppSession.CurrentUser.Id, EN_Screens.AgeGroup, EN_Permissions.Delete))
            {
                {
                    return Ok(new ResponseModel
                    {
                        ModelState = EN_ModelState.NotValid,
                        Status = EN_ResponseStatus.Faild,
                        Message = "User has no permission to delete this AgeGroup!!",
                        Data = new { }
                    });
                }
            }
            try
            {
                var dbObj = _uow.AgeGroupRepository.GetById(id);
                if (dbObj == null)
                {
                    return Ok(new ResponseModel
                    {
                        ModelState = EN_ModelState.NotFound,
                        Status = EN_ResponseStatus.Faild,
                        Message = "This Item Is Not Found!!",
                        Data = new {  }
                    });
                }
                else
                {
                    dbObj.IsDeleted = true;
                    dbObj.ModifiedBy = AppSession.CurrentUser.Id;
                    dbObj.ModificationDate = DateTime.Now;
                    _uow.AgeGroupRepository.Update(dbObj);

                    _uow.Save();
                }
                return Ok(new ResponseModel
                {
                    ModelState = EN_ModelState.Success,
                    Status = EN_ResponseStatus.Success,
                    Message = "Done",
                    Data = new { dbObj }

                });
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }


    }
}
