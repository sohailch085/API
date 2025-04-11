using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.TwoOneSeveenNotice
{
    [Route("api/R2Switches")]
    [ApiController]
    public class R2SwitchesController : ControllerBase
    {
        private readonly TwoOneSeveenNoticeTwoInterface _TwoOneSeveenNoticeTwoInterface;
        public R2SwitchesController(TwoOneSeveenNoticeTwoInterface twoOneSeveenNoticeTwoInterface)
        {
            _TwoOneSeveenNoticeTwoInterface = twoOneSeveenNoticeTwoInterface;
        }
        [HttpGet]
        [Route("GetR2Switches")]
        public async Task<JsonResult> GetR2Switches()
        {
            try
            {
                var result = await _TwoOneSeveenNoticeTwoInterface.GetR2Switches();
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
        [Route("ExecuteSPR2Switches")]
        public async Task<JsonResult> ExecuteSPR2Switches(R2SwitchesCollectionDto request)
        {
            try
            {
                var result = await _TwoOneSeveenNoticeTwoInterface.ExecuteSPR2Switches(
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
