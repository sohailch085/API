using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.TwoOneSeveenNotice
{
    [Route("api/R2Thyristor")]
    [ApiController]
    public class R2ThyristorController : ControllerBase
    {
        private readonly TwoOneSeveenNoticeTwoInterface _TwoOneSeveenNoticeTwoInterface;
        public R2ThyristorController(TwoOneSeveenNoticeTwoInterface twoOneSeveenNoticeTwoInterface)
        {
            _TwoOneSeveenNoticeTwoInterface = twoOneSeveenNoticeTwoInterface;
        }
        [HttpGet]
        [Route("GetR2Thyristor")]
        public JsonResult GetR2Thyristor()
        {
            try
            {
                var result = _TwoOneSeveenNoticeTwoInterface.GetR2Thyristor();
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
        [Route("ExecuteSPR2Thyristor")]
        public async Task<JsonResult> ExecuteSPR2Thyristor(R2ThyristorCollectionDto request)
        {
            try
            {
                var result = await _TwoOneSeveenNoticeTwoInterface.ExecuteSPR2Thyristor(
                    request.PartType,
                    request.NoOFYears,
                    request.TemperatureRise,
                    request.TemperatureOveride,
                    request.AmbientTemperatureOperating,
                    request.AmbientTemperatureNonoperating,
                    request.DutyCycle,
                    request.CyclingRate,
                    request.AppliedVoltage,
                    request.RatedVoltage
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
