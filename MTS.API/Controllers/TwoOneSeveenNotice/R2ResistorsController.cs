using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.TwoOneSeveenNotice
{
    [Route("api/R2Resistors")]
    [ApiController]
    public class R2ResistorsController : ControllerBase
    {
        private readonly TwoOneSeveenNoticeTwoInterface _TwoOneSeveenNoticeTwoInterface;
        public R2ResistorsController(TwoOneSeveenNoticeTwoInterface twoOneSeveenNoticeTwoInterface)
        {
            _TwoOneSeveenNoticeTwoInterface = twoOneSeveenNoticeTwoInterface;
        }
        [HttpGet]
        [Route("GetR2Resistors")]
        public JsonResult GetR2Resistors()
        {
            try
            {
                var result = _TwoOneSeveenNoticeTwoInterface.GetR2Resistors();
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
        [Route("ExecuteSPR2Resistors")]
        public async Task<JsonResult> ExecuteSPR2Resistors(R2ResistorsCollectionDto request)
        {
            try
            {
                var result = await _TwoOneSeveenNoticeTwoInterface.ExecuteSPR2Resistors(
                    request.PartType,
                    request.NoOFYears,
                    request.TemperatureRise,
                    request.TemperatureOveride,
                    request.AmbientTemperatureOperating,
                    request.AmbientTemperatureNonoperating,
                    request.DutyCycle,
                    request.CyclingRate,
                    request.PowerRate
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
