using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.TwoOneSeveenNotice
{
    [Route("api/R2OptoelectronicDevices")]
    [ApiController]
    public class R2OptoelectronicDevicesController : ControllerBase
    {
        private readonly TwoOneSeveenNoticeTwoInterface _TwoOneSeveenNoticeTwoInterface;
        public R2OptoelectronicDevicesController(TwoOneSeveenNoticeTwoInterface TwoOneSeveenNoticeTwoInterface)
        {
            _TwoOneSeveenNoticeTwoInterface = TwoOneSeveenNoticeTwoInterface;
        }
        [HttpGet]
        [Route("GetR2OptoelectronicDevices")]
        public async Task<JsonResult> GetR2OptoelectronicDevices()
        {
            try
            {
                var result = await _TwoOneSeveenNoticeTwoInterface.GetR2OptoelectronicDevices();
                if (result == null || !result.Any())
                {
                    return new JsonResult(new
                    {
                        message = MessageInfo.Null
                    });
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
        [Route("ExecuteSPR2OptoelectronicDevices")]
        public async Task<JsonResult> ExecuteSPR2OptoelectronicDevices(R2OptoelectronicDevicesCollectionDto request)
        {
            try
            {
                var result = await _TwoOneSeveenNoticeTwoInterface.ExecuteSPR2OptoelectronicDevices(
                    request.PartType,
                    request.NoOFYears,
                    request.TemperatureRise,
                    request.TemperatureOveride,
                    request.AmbientTemperatureOperating,
                    request.AmbientTemperatureNonoperating,
                    request.DutyCycle,
                    request.CyclingRate
                );
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

    }
}
