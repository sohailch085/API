using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.Entities;

namespace MTS.API.Controllers
{
    [Route("api/PreductionHandBooks")]
    [ApiController]
    public class PredictionHandBookController : ControllerBase
    {
        private readonly ApplicationScopInterface _ApplicationScopInterface;
        public PredictionHandBookController(ApplicationScopInterface applicationScopInterface)
        {
            _ApplicationScopInterface = applicationScopInterface;
        }
        [HttpGet]
        [Route("GetProductTypes")]
        public JsonResult GetProductTypes()
        {
            try
            {
                var result = _ApplicationScopInterface.GetProductTypes();
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
        [HttpGet]
        [Route("GetPredictionHandBook")]
        public JsonResult GetPredictionHandBook()
        {
            try
            {
                var result = _ApplicationScopInterface.GetPredictionHandBook();
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
      
        [HttpPost]
        [Route("SaveHandBook")]
        public JsonResult SaveHandBook(PredictionHandBookDto handBookDto)
        {
            try
            {
                var result =_ApplicationScopInterface.SaveHandBook(handBookDto);
                if (result == false)
                {
                    return new JsonResult(new { message = MessageInfo.Null });
                }
                return new JsonResult(new
                {
                    message = MessageInfo.Successfully,
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
        [Route("DeleteHandBook")]
        public async Task<JsonResult> DeleteHandBook(int BookId)
        {
            try
            {
                var result =await _ApplicationScopInterface.DeleteHandBook(BookId);
                if (result == false)
                {
                    return new JsonResult(new { message = MessageInfo.Null });
                }
                return new JsonResult(new { message = MessageInfo.Deleted});
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    message = MessageInfo.Error + ex.Message
                });
            }
        }      
    }
}
