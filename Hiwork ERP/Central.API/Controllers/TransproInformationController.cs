﻿using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using HiWork.BLL.Models;
using HiWork.BLL.Responses;
using HiWork.BLL.ViewModels;
using HiWork.BLL.Services;
using HiWork.Utils.Infrastructure.Contract;
using HiWork.DAL.Repositories;
using System.Net;
using System;
using HiWork.Utils.Infrastructure;

namespace Central.API.Controllers
{
    [Authorize]
    public class TransproInformationController : ApiController
    {
        [Route("TransproInformation/save")]
        [HttpPost]
        public HttpResponseMessage Save(TransproInformationModel aTransproInformationModel)
        {
            IUnitOfWork uWork = new UnitOfWork();
            ITransproInformationRepository transproInformation = new TransproInformationRepository(uWork);
            ITransproInformationService transproInformationService = new TransproInformationService(transproInformation);

            try
            {
                if (this.ModelState.IsValid)
                {
                    var TransproInformationList = transproInformationService.SaveTransproInformation(aTransproInformationModel);
                    if (TransproInformationList != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, TransproInformationList);
                    }
                    else
                    {
                        string message = "Error Saving Data";
                        return Request.CreateErrorResponse(HttpStatusCode.Forbidden, message);
                    }

                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.InnerException.Message);
            }
        }

        [Route("TransproInformation/list")]
        [HttpPost]
        public HttpResponseMessage GetTransproInformationModels(BaseViewModel model)
        {
            IUnitOfWork uWork = new UnitOfWork();
            ITransproInformationRepository transproInformation = new TransproInformationRepository(uWork);
            ITransproInformationService transproInformationService = new TransproInformationService(transproInformation);
            try
            {
                if (this.ModelState.IsValid)
                {
                    var TransproInformationList = transproInformationService.GetAllTransproInformationList(model);
                    if (TransproInformationList != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, TransproInformationList);
                    }
                    else
                    {
                        string message = "Error in getting Data";
                        return Request.CreateErrorResponse(HttpStatusCode.Forbidden, message);
                    }

                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.InnerException.Message);
            }

        }

        [Route("TransproInformation/delete")]
        [HttpPost]
        public HttpResponseMessage DeleteTransproInformation(TransproInformationModel model)
        {
            IUnitOfWork uWork = new UnitOfWork();
            ITransproInformationRepository transproInformation = new TransproInformationRepository(uWork);
            ITransproInformationService transproInformationService = new TransproInformationService(transproInformation);

            try
            {
                if (this.ModelState.IsValid)
                {
                    var result = transproInformationService.DeleteTransproInformation(model);
                    if (result != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, result);
                    }
                    else
                    {
                        string message = "Not deleted successfully";
                        return Request.CreateErrorResponse(HttpStatusCode.Forbidden, message);
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

        }
    }
}
