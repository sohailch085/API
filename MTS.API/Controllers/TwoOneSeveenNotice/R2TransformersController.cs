using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.TwoOneSeveenNotice
{
    [Route("api/R2Transformers")]
    [ApiController]
    public class R2TransformersController : ControllerBase
    {
        private readonly TwoOneSeveenNoticeTwoInterface _twoOneSeveenNoticeTwoInterface;
        public R2TransformersController(TwoOneSeveenNoticeTwoInterface twoOneSeveenNoticeTwoInterface)
        {
            _twoOneSeveenNoticeTwoInterface = twoOneSeveenNoticeTwoInterface;
        }
        [HttpGet]
        [Route("GetR2Transformers")]
        public async Task<ActionResult> GetR2Transformers()
        {
            try
            {
                var result = await _twoOneSeveenNoticeTwoInterface.GetR2Transformers();
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
        [Route("ExecuteSPR2Transformers")]
        public async Task<ActionResult> ExecuteSPR2Transformers([FromBody] R2TransformersCollectionDto request)
        {
            try
            {
                var result = await _twoOneSeveenNoticeTwoInterface.ExecuteSPR2Transformers
                    (
                        request.PartType,
                        request.NoOFYears,
                        request.TemperatureRise,
                        request.TemperatureOveride,
                        request.AmbientTemperatureOperating,
                        request.AmbientTemperatureNonoperating,
                        request.DutyCycle,
                        request.CyclingRate
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
    }
}
