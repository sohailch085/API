using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers
{
    [Route("api/Lifecyclephases")]
    [ApiController]
    public class LifecyclephasesController : ControllerBase
    {
        public readonly ApplicationScopInterface _ApplicationScopInterface;
        public LifecyclephasesController(ApplicationScopInterface applicationScop)
        {
            _ApplicationScopInterface= applicationScop;
        }
        [HttpGet]
        [Route("GetLifecyclephases")]
        public JsonResult GetLifecyclephases()
        {
            try
            {
                var result = _ApplicationScopInterface.GetLifecyclephases();
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
        [Route("SaveLifecyclephases")]
        public JsonResult SaveLifecyclephases(LifecyclephasesCollectionDto Lifecycle)
        {
            try
            {
                var result = _ApplicationScopInterface.SaveLifecyclephases(Lifecycle);
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
        [Route("DeleteLifecyclephases")]
        public async Task<JsonResult> DeleteLifecyclephases(int Trid)
        {
            try
            {
                var result = await _ApplicationScopInterface.DeleteLifecyclephases(Trid);
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
    }
}
