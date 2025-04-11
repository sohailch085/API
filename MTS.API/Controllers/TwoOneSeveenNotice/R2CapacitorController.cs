using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.TwoOneSeveenNotice
{
    [Route("api/R2Capacitor")]
    [ApiController]
    public class R2CapacitorController : ControllerBase
    {
        private readonly TwoOneSeveenNoticeTwoInterface _TwoOneSevenNoticeTwoInterface;

        public R2CapacitorController(TwoOneSeveenNoticeTwoInterface twoOneSevenNoticeTwoInterface)
        {
            _TwoOneSevenNoticeTwoInterface = twoOneSevenNoticeTwoInterface;
        }

        [HttpGet]
        [Route("GetR2Capacitors")]
        public async Task<ActionResult> GetR2Capacitors()
        {
            try
            {
                var result = await _TwoOneSevenNoticeTwoInterface.GetR2Capacitors();
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
        [Route("ExecuteSPR2Capacitor")]
        public async Task<ActionResult> ExecuteSPR2Capacitor([FromBody] R2CapacitorCollectionDto request)
        {
            try
            {
                var result = await _TwoOneSevenNoticeTwoInterface.ExecuteSPR2Capacitor
                    (
                        request.PartType,
                        request.Capacitance,
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
