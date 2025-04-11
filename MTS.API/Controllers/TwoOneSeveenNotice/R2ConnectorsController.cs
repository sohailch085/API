using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.TwoOneSeveenNotice
{
    [Route("api/R2Connectors")]
    [ApiController]
    public class R2ConnectorsController : ControllerBase
    {
        private readonly TwoOneSeveenNoticeTwoInterface _TwoOneSeveenNoticeTwoInterface;
        public R2ConnectorsController(TwoOneSeveenNoticeTwoInterface twoOneSeveenNoticeTwoInterface)
        {
            _TwoOneSeveenNoticeTwoInterface = twoOneSeveenNoticeTwoInterface;
        }
        [HttpGet]
        [Route("GetR2Connectors")]
        public JsonResult GetR2Connectors()
        {
            try
            {
                var result = _TwoOneSeveenNoticeTwoInterface.GetR2Connectors();
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
        [Route("ExecuteSPR2Connectors")]
        public async Task<JsonResult> ExecuteSPR2Connectors(R2ConnectorsCollectionDto request)
        {
            try
            {
                var result = await _TwoOneSeveenNoticeTwoInterface.ExecuteSPR2Connectors(
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
