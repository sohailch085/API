using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.IEC
{
    [Route("api/IECSwitchesAndPushButtonsForLowElectricalStress")]
    [ApiController]
    public class IECSwitchesAndPushButtonsForLowElectricalStressController : ControllerBase
    {
        private readonly IECInterface _IEInterface;
        public IECSwitchesAndPushButtonsForLowElectricalStressController(IECInterface eCInterface)
        {
            _IEInterface = eCInterface;
        }
        [HttpGet]
        [Route("GetIECSwitchesAndPushButtonsForLowElectricalStress")]
        public async Task<ActionResult> GetIECSwitchesAndPushButtonsForLowElectricalStress()
        {
            try
            {
                var result = await _IEInterface.GetIECSwitchesAndPushButtonsForLowElectricalStress();

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
                var result = await _IEInterface.GetIECRegionType(RegionId);

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
                var result = await _IEInterface.GetIECRelayLoadType();

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
                var result = await _IEInterface.GetIECRelayLoadCategory();

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
        [Route("ExecuteSPIECSwitchesAndPushButtonsForLowElectricalStress")]
        public async Task<ActionResult> ExecuteSPIECSwitchesAndPushButtonsForLowElectricalStress([FromBody] IECSwitchesAndPushButtonsForLowElectricalStressCollectionDto request)
        {
            try
            {
                var result = await _IEInterface.ExecuteSPIECSwitchesAndPushButtonsForLowElectricalStress
                    (
                        request.RegionType,
                        request.LoadType,
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
        [Route("GetIECPreductionSwitchesAndPushButtonsForLowElectricalStress")]
        public async Task<JsonResult> GetIECPreductionSwitchesAndPushButtonsForLowElectricalStress()
        {
            try
            {
                var result = await _IEInterface.GetIECPreductionSwitchesAndPushButtonsForLowElectricalStress();

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
        [Route("SaveSwitchesAndPushButtonsForLowElectricalStress")]
        public async Task<JsonResult> SaveSwitchesAndPushButtonsForLowElectricalStress(IECPreductionSwitchesAndPushButtonsForLowElectricalStressDto request)
        {
            try
            {
                var result = await _IEInterface.SaveSwitchesAndPushButtonsForLowElectricalStress(request);
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
        [Route("DeleteSwitchesAndPushButtonsForLowElectricalStress")]
        public async Task<JsonResult> DeleteSwitchesAndPushButtonsForLowElectricalStress(int Trid)
        {
            try
            {
                var result = await _IEInterface.DeleteSwitchesAndPushButtonsForLowElectricalStress(Trid);
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
