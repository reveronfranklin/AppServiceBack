﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AppService.Api.Responses;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppGeneralQuotesController : ControllerBase
    {
        private readonly IAppGeneralQuotesService _appGeneralQuotesService;
        private readonly ICotizacionService _cotizacionService;

        public AppGeneralQuotesController(IAppGeneralQuotesService appGeneralQuotesService,
                                           ICotizacionService cotizacionService)
        {
            _appGeneralQuotesService = appGeneralQuotesService;
            _cotizacionService = cotizacionService;
        }

        /// <summary>
        /// Retorna los datos de AppGeneralQuotes
        /// Filtros a aplicar AppGeneralQuotesQueryFilter, si en el objeto incluye Cotizacion, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppGeneralQuotesQueryFilter, si en el objeto incluye Cotizacion, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppGeneralQuotesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllAppGeneralQuotes(AppGeneralQuotesQueryFilter filters)
        {
                                                  
            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {

               
                var generalQuotes = await _appGeneralQuotesService.GetAllAppGeneralQuotes(filters);

                if (generalQuotes!=null)
                {
                    metadata.IsValid = true;
                    metadata.Message = "";
                    metadata.TotalCount = generalQuotes.TotalCount;
                    metadata.PageSize = generalQuotes.PageSize;
                    metadata.CurrentPage = generalQuotes.CurrentPage;
                    metadata.TotalPage = generalQuotes.TotalPage;
                    metadata.HasNextPage = generalQuotes.HasNextPage;
                    metadata.HasPreviousPage = generalQuotes.HasPreviousPage;
                    metadata.NextPageUrl = "";
                    metadata.PreviousPageUrl = "";

                    ApiResponse<List<AppGeneralQuotesGetDto>> response = new ApiResponse<List<AppGeneralQuotesGetDto>>(generalQuotes)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }
                else
                {
                    metadata.IsValid = true;
                    metadata.Message = "No Data.......";
                    metadata.TotalCount = 0;
                    metadata.PageSize = filters.PageSize;
                    metadata.CurrentPage =0;
                    metadata.TotalPage = filters.PageNumber;
                    metadata.HasNextPage = false;
                    metadata.HasPreviousPage = false;
                    metadata.NextPageUrl = "";
                    metadata.PreviousPageUrl = "";

                    ApiResponse<List<AppGeneralQuotesGetDto>> response = new ApiResponse<List<AppGeneralQuotesGetDto>>(generalQuotes)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }
               

            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<IEnumerable<CobAdjuntosCobranzaDto>>(null)
                {
                    Meta = metadata
                };

              
                return Ok(responseError);
            }

          
        }

        /// <summary>
        /// Crea y Retorna los datos de AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppGeneralQuotesQueryFilter, si en el objeto incluye Cotizacion, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppGeneralQuotesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> InsertGeneralQuotes(AppGeneralQuotesCreateDto appGeneralQuotesCreateDto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var generalQuotes = await _appGeneralQuotesService.InsertGeneralQuotes(appGeneralQuotesCreateDto);
                return Ok(generalQuotes);
              


            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }



        /// <summary>
        /// Actualiza y Retorna los datos de AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppGeneralQuotesQueryFilter, si en el objeto incluye Cotizacion, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppGeneralQuotesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateGeneralQuotes(AppGeneralQuotesUpdateDto appGeneralQuotesUpdateDto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var generalQuotes = await _appGeneralQuotesService.UpdateGeneralQuotes(appGeneralQuotesUpdateDto);
                await _cotizacionService.IntegrarCotizacion(appGeneralQuotesUpdateDto.Id);
                return Ok(generalQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }



        /// <summary>
        /// Elimina AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">N/A</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteGeneralQuotes(AppGeneralQuotesDeleteDto appGeneralQuotesDeleteDto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var generalQuotes = await _appGeneralQuotesService.DeleteGeneralQuotes(appGeneralQuotesDeleteDto);
                return Ok(generalQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }


        /// <summary>
        /// Enviar al Cliente
        ///  
        /// 
        /// </summary>
        /// <param name="filters">N/A</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppGeneralQuotesGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> EnviarAlCliente(AppGeneralQuotesChangeStatusDto dto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var generalQuotes = await _appGeneralQuotesService.EnviarAlCliente(dto);
                return Ok(generalQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }


    }
}