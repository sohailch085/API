using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.TwoOneSeveenNotice
{
    [Route("api/R2IntegratedCircuitsPlasticEncapsulatedORHermetic")]
    [ApiController]
    public class R2IntegratedCircuitsPlasticEncapsulatedORHermeticController : ControllerBase
    {
        private readonly TwoOneSeveenNoticeTwoInterface _TwoOneSevenNoticeTwoInterface;
        public R2IntegratedCircuitsPlasticEncapsulatedORHermeticController(TwoOneSeveenNoticeTwoInterface twoOneSeveenNoticeTwoInterface)
        {
            _TwoOneSevenNoticeTwoInterface = twoOneSeveenNoticeTwoInterface;
        }
        [HttpGet]
        [Route("GetR2IntegratedCircuitsPlasticEncapsulatedPackageType")]
        public async Task<ActionResult> GetR2IntegratedCircuitsPlasticEncapsulatedPackageType()
        {
            try
            {
                var result = await _TwoOneSevenNoticeTwoInterface.GetR2IntegratedCircuitsPlasticEncapsulatedPackageType();
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
        [Route("GetR2IntegratedCircuitsPlasticEncapsulatedPartType")]
        public async Task<ActionResult> GetR2IntegratedCircuitsPlasticEncapsulatedPartType(int PakageTypeId)
        {
            try
            {
                var result = await _TwoOneSevenNoticeTwoInterface.GetR2IntegratedCircuitsPlasticEncapsulatedPartType(PakageTypeId);
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
        [Route("ExecuteSPR2EncapsulatedORHermetic")]
        public async Task<ActionResult> ExecuteSPR2EncapsulatedORHermetic([FromBody] R2IntegratedCircuitsPlasticEncapsulatedORHermeticCollectionDto request)
        {
            try
            {
                var result = await _TwoOneSevenNoticeTwoInterface.ExecuteSPR2EncapsulatedORHermetic
                    (
                        request.PackageType,
                        request.PartType,
                        request.NoOFYears,
                        request.TemperatureRise,
                        request.TemperatureOveride,
                        request.AmbientTemperatureOperating,
                        request.AmbientTemperatureNonoperating,
                        request.RelativeHumidity,
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
