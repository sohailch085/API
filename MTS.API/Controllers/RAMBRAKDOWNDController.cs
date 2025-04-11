using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers
{
    [Route("api/RAMBRAKDOWND")]
    [ApiController]
    public class RAMBRAKDOWNDController : ControllerBase
    {
        private readonly ApplicationScopInterface _ApplicationScopInterface;
        public RAMBRAKDOWNDController(ApplicationScopInterface applicationScopInterface)
        {
            _ApplicationScopInterface = applicationScopInterface;
        }
        [HttpGet]
        [Route("GetRambrakdowns")]
        public async Task<JsonResult> GetRambrakdowns()
        {
            try
            {
                var result =await _ApplicationScopInterface.GetRambrakdowns();
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
        [Route("GetRAMBRAKDOWNPARTS")]
        public async Task<JsonResult> GetRAMBRAKDOWNPARTS()
        {
            try
            {
                var result =await _ApplicationScopInterface.GetRAMBRAKDOWNPARTS();
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
        [Route("DeleteRambrakdowns")]
        public async Task<JsonResult> DeleteRambrakdowns(string WBS)
        {
            try
            {
                var result = await _ApplicationScopInterface.DeleteRambrakdowns(WBS);
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
        [HttpDelete]
        [Route("DeleteRAMBRAKDOWNPARTS")]
        public async Task<JsonResult> DeleteRAMBRAKDOWNPARTS(string WBS)
        {
            try
            {
                var result = await _ApplicationScopInterface.DeleteRAMBRAKDOWNPARTS(WBS);
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
        [Route("SaveRambrakdowns")]
        public JsonResult SaveRambrakdowns(RamBrakdownCollectionDto collectionDto)
        {
            try
            {
                var result = _ApplicationScopInterface.SaveRambrakdowns(collectionDto);
                return new JsonResult(new { message = MessageInfo.Successfully});
            }
            catch (Exception ex)
            {
                return new JsonResult(new { message = MessageInfo.Error + ex.Message });
            }
        }
        [HttpPost]
        [Route("SaveRAMBRAKDOWNPARTS")]
        public JsonResult SaveRAMBRAKDOWNPARTS(RambrakdownPartsCollectionDto collectionDto)
        {
            try
            {
                var result = _ApplicationScopInterface.SaveRAMBRAKDOWNPARTS(collectionDto);
                return new JsonResult(new { message = MessageInfo.Successfully});
            }
            catch (Exception ex)
            {
                return new JsonResult(new { message = MessageInfo.Error + ex.Message });
            }
        }
    }
}
