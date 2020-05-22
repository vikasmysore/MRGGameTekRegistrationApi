using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using MRGGameTekRegistrationApi.Models;
using MRGGameTekRegistrationApi.Services;

namespace MRGGameTekRegistrationApi.Controllers
{
    [ApiController]
    [Route("[controller]/api/v1/")]
    public class MrGreenController : ControllerBase
    {
         private readonly IAccounts<MrGreenRegistration> accounts;

         public MrGreenController(IAccounts<MrGreenRegistration> accounts)
         {
             this.accounts = accounts;
         }
        
        [HttpGet]
        [Route("GetAllCustomers")]
        public IList<MrGreenRegistration> GetAllCustomers()
        {
            return accounts.GetAllCustomerData();
        }

        [HttpGet]
        [Route("GetCustomer/{id}")]
        public MrGreenRegistration GetCustomer(Guid id)
        {
            return accounts.GetCustomerDataById(id);
        }

        [HttpPost]
        [Route("Register")]
        public HttpResponseMessage Register([FromBody] MrGreenRegistration entity)
        {
            if(ModelState.IsValid)
            {
                if(accounts.RegisterUser(entity))
                return new HttpResponseMessage(HttpStatusCode.OK);
                else
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        [Route("Update")]
        public HttpResponseMessage UpdateCustomer([FromBody] MrGreenRegistration entity)
        {
            if(ModelState.IsValid)
            {
                if(accounts.UpdateCustomerData(entity))
                return new HttpResponseMessage(HttpStatusCode.OK);
                else
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        [HttpDelete]
        [Route("Delete")]
        public HttpResponseMessage DeleteCustomer(Guid id)
        {
            if(id == null)
            {
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            if(accounts.DeleteCustomerData(id))
                return new HttpResponseMessage(HttpStatusCode.OK);
                else
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            
        }
    }
}