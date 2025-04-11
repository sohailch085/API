using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.Entities.IEC;

namespace MTS.API.Controllers.IEC
{
    [Route("api/IECRelays")]
    [ApiController]
    public class IECRelaysController : ControllerBase
    {
        private readonly IECInterface _IECInterface;
        public IECRelaysController(IECInterface ecInterface)
        {
            _IECInterface = ecInterface;
        }
        [HttpGet]
        [Route("GetIECConstantsForTemperatureDependenceOfRelays")]
        public async Task<ActionResult> GetIECConstantsForTemperatureDependenceOfRelays()
        {
            try
            {
                var result = await _IECInterface.GetIECConstantsForTemperatureDependenceOfRelays();

                if (result == null || !result.Any())
                {
                    return NotFound(new { message = MessageInfo.Null });
                }
                return Ok(new
                {
                    message = MessageInfo.Retrieved,
                    data = result
                });
            }
            catch (Exception ex)
            {
                return Ok(new
                {
                    message = MessageInfo.Error + ex.Message
                });
            }
        }
        [HttpGet]
        [Route("GetIECRelay")]
        public async Task<ActionResult> GetIECRelay()
        {
            try
            {
                var result = await _IECInterface.GetIECRelay();

                if (result == null || !result.Any())
                {
                    return NotFound(new { message = MessageInfo.Null });
                }
                return Ok(new
                {
                    message = MessageInfo.Retrieved,
                    data = result
                });
            }
            catch (Exception ex)
            {
                return Ok(new
                {
                    message = MessageInfo.Error + ex.Message
                });
            }
        }
        [HttpGet]
        [Route("GetIECRegionType")]
        public async Task<ActionResult> GetIECRegionType(int RegionId)
        {
            try
            {
                var result = await _IECInterface.GetIECRegionType(RegionId);

                if (result == null || !result.Any())
                {
                    return NotFound(new { message = MessageInfo.Null });
                }
                return Ok(new
                {
                    message = MessageInfo.Retrieved,
                    data = result
                });
            }
            catch (Exception ex)
            {

                return Ok(new
                {
                    message = MessageInfo.Error + ex.Message
                });
            }
        }
        [HttpGet]
        [Route("GetIECRelayLoadType")]
        public async Task<ActionResult> GetIECRelayLoadType()
        {
            try
            {
                var result = await _IECInterface.GetIECRelayLoadType();

                if (result == null || !result.Any())
                {
                    return NotFound(new { message = MessageInfo.Null });
                }
                return Ok(new
                {
                    message = MessageInfo.Retrieved,
                    data = result
                });
            }
            catch (Exception ex)
            {
                return Ok(new
                {
                    message = MessageInfo.Error + ex.Message
                });
            }
        }
        [HttpGet]
        [Route("GetIECRelayLoadCategory")]
        public async Task<ActionResult> GetIECRelayLoadCategory()
        {
            try
            {
                var result = await _IECInterface.GetIECRelayLoadCategory();

                if (result == null || !result.Any())
                {
                    return NotFound(new { message = MessageInfo.Null });
                }
                return Ok(new
                {
                    message = MessageInfo.Retrieved,
                    data = result
                });
            }
            catch (Exception ex)
            {

                return Ok(new
                {
                    message = MessageInfo.Error + ex.Message
                });
            }
        }
        [HttpPost]
        [Route("ExecuteSPIECRelays")]
        public async Task<ActionResult> ExecuteSPIECRelays([FromBody] IECRelaysCollectionDto request)
        {
            try
            {
                var result = await _IECInterface.ExecuteSPIECRelays
                    (
                        request.SupportingConstructionType,
                        request.LoadType,
                        request.RegionType,
                        request.NumberOfOperatingCyclesPerHour,
                        request.ReferenceNumberOperatingCyclesPerHour,
                        request.AmbientTemperature,
                        request.LambdaRef
                    );

                return Ok(new
                {
                    message = MessageInfo.Retrieved,
                    data = result
                });
            }
            catch (Exception ex)
            {

                return Ok(new
                {
                    message = MessageInfo.Error + ex.Message
                });
            }
        }

        [HttpGet]
        [Route("GetIECPreductionRelays")]
        public async Task<JsonResult> GetIECPreductionRelays()
        {
            try
            {
                var result = await _IECInterface.GetIECPreductionRelays();

                if (result == null || !result.Any())
                {
                    return new JsonResult(new { message = MessageInfo.Null });
                }
                return new JsonResult(new
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
        [Route("SaveRelays")]
        public async Task<JsonResult> SaveRelays(IECPreductionRelaysDto request)
        {
            try
            {
                var result = await _IECInterface.SaveRelays(request);
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
        [Route("DeleteRelays")]
        public async Task<JsonResult> DeleteRelays(int Trid)
        {
            try
            {
                var result = await _IECInterface.DeleteRelays(Trid);
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
