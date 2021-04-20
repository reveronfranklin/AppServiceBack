using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AppService.Api.Responses;
using AppService.Core.DTOs;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppProductsController : ControllerBase
    {
        private readonly IAppProductsService _appProductsService;

        public AppProductsController(IAppProductsService appProductsService )
        {
            _appProductsService = appProductsService;
        }



        /// <summary>
        /// Retorna los datos de AppProductsGetDto
        /// Filtros a aplicar AppGeneralQuotesQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppUnitsQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppProductsGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllAppProducts(AppProdutsQueryFilter filters)
        {



                var response = await _appProductsService.GetAll(filters);
            return Ok(response);



        }

        /// <summary>
        /// Retorna los datos de AppProductsGetDto
        /// Filtros a aplicar AppGeneralQuotesQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppUnitsQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppProductsGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllAppProductsByVariable(List<AppVariableSearchCompareQueryFilter> filters)
        {



            var response = await _appProductsService.GetAllByVariable(filters);
            return Ok(response);



        }





        /// <summary>
        /// Se crea registro de AppProducts
        /// , 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppProductsGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> InsertAppProducts(AppProductsCreateDto appProductsCreateDto )
        {



            var response = await _appProductsService.InsertProducts(appProductsCreateDto);
            return Ok(response);



        }

        /// <summary>
        /// Actualiza de AppProducts
        /// , 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppProductsGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateAppProducts(AppProductsUpdateDto appProductsUpdateDto)
        {



            var response = await _appProductsService.UpdateProducts(appProductsUpdateDto);
            return Ok(response);



        }


        /// <summary>
        /// Elimina Prorducto
        /// Filtros a aplicar AppVariablesCreateDto, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteProduct(AppProductsDeleteDto dto)
        {


            var response = await _appProductsService.DeleteProduct(dto);
            return Ok(response);



        }

    }
}