using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;
using System.Net;

namespace MTS.API.Controllers
{
    [Route("api/PredictionCategories")]
    [ApiController]
    public class PredictionCategoriesController : ControllerBase
    {
        private readonly ApplicationScopInterface _ApplicationScopInterface;
        public PredictionCategoriesController(ApplicationScopInterface applicationScopInterface)
        {
            _ApplicationScopInterface = applicationScopInterface;
        }
        [HttpGet]
        [Route("GetPredictionCategories")]
        public JsonResult GetPredictionCategories(int BookId)
        {
            try
            {
                var result = _ApplicationScopInterface.GetPredictionCategories(BookId);
                if (result == null || !result.Any())
                {
                    return new JsonResult(new { message = MessageInfo.Null });
                }
                return new JsonResult
                    (new
                    {
                        message = MessageInfo.Retrieved,
                        data = result
                    });
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    message = MessageInfo.Error + ex.Message
                });
            }
        }
        [HttpDelete]
        [Route("DeletePredictionCategories")]
        public async Task<JsonResult> DeletePredictionCategories(int Trid)
        {
            try
            {
                var result =await _ApplicationScopInterface.DeletePredictionCategories(Trid);
                if (result == false)
                {
                    return new JsonResult(new { message = MessageInfo.Null });
                }
                return new JsonResult(new { message = MessageInfo.Deleted });
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    message = MessageInfo.Error + ex.Message
                });
            }                    
        }
        [HttpPost]
        [Route("SavePredictionCategories")]
        public JsonResult SavePredictionCategories(PredictionCategoriesCollectionDto collectionDto)
        {
            try
            {
                var result = _ApplicationScopInterface.SavePredictionCategories(collectionDto);
                return new JsonResult(new { message = MessageInfo.Successfully });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { message = MessageInfo.Error + ex.Message });
            }
        }
    }
}
