using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.TwoOneSeveenNotice
{
    [Route("api/R2Diode")]
    [ApiController]
    public class R2DiodeController : ControllerBase
    {
        private readonly TwoOneSeveenNoticeTwoInterface _TwoOneSevenNoticeTwoInterface;
        public R2DiodeController(TwoOneSeveenNoticeTwoInterface twoOneSeveenNoticeTwoInterface)
        {
            _TwoOneSevenNoticeTwoInterface = twoOneSeveenNoticeTwoInterface;
        }
        [HttpGet]
        [Route("GetR2Diode")]
        public async Task<ActionResult> GetR2Diode()
        {
            try
            {
                var result = await _TwoOneSevenNoticeTwoInterface.GetR2Diode();
                if (result == null || !result.Any())
                {
                    return NotFound(new { message = MessageInfo.Error });
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
        [Route("ExecuteSPR2Diode")]
        public async Task<ActionResult> ExecuteSPR2Diode([FromBody] R2DiodeCollectionDto request)
        {
            try
            {
                var result = await _TwoOneSevenNoticeTwoInterface.ExecuteSPR2Diode
                    (
                        request.PartType,
                        request.NoOfYears,
                        request.AppliedVoltage,
                        request.RatedVoltage,
                        request.TemperatureRise,
                        request.TemperatureOverride,
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
