using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.TwoOneSeveenNotice
{
    [Route("api/R2Inductors")]
    [ApiController]
    public class R2InductorsController : ControllerBase
    {
        private readonly TwoOneSeveenNoticeTwoInterface _TwoOneSevenNoticeTwoInterface;
        public R2InductorsController(TwoOneSeveenNoticeTwoInterface twoOneSeveenNoticeTwoInterface)
        {
            _TwoOneSevenNoticeTwoInterface = twoOneSeveenNoticeTwoInterface;
        }
        [HttpGet]
        [Route("GetR2Inductors")]
        public async Task<ActionResult> GetR2Inductors()
        {
            try
            {
                var result = await _TwoOneSevenNoticeTwoInterface.GetR2Inductors();
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
        [Route("ExecuteSPR2Inductors")]
        public async Task<ActionResult> ExecuteSPR2Inductors([FromBody] R2InductorsCollectionDto request)
        {
            try
            {
                var result = await _TwoOneSevenNoticeTwoInterface.ExecuteSPR2Inductors
                    (
                        request.PartType,
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
