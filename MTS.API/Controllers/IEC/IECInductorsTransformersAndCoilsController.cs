using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.IEC
{
    [Route("api/IECInductorsTransformersAndCoils")]
    [ApiController]
    public class IECInductorsTransformersAndCoilsController : ControllerBase
    {
        private readonly IECInterface _IECInterface;
        public IECInductorsTransformersAndCoilsController(IECInterface ecinterface)
        {
            _IECInterface = ecinterface;
        }
        [HttpGet]
        [Route("GetIECInductorsTransformersAndCoils")]
        public JsonResult GetIECInductorsTransformersAndCoils()
        {
            try
            {
                var result = _IECInterface.GetIECInductorsTransformersAndCoils();

                if (result == null || !result.Any())
                {
                    return new JsonResult(new { message = MessageInfo.Null });
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
        [Route("ExecuteSPIECInductorsTransformersAndCoils")]
        public async Task<ActionResult> ExecuteSPIECInductorsTransformersAndCoils([FromBody] IECInductorsTransformersAndCoilsCollectionDto request)
        {
            try
            {
                var result = await _IECInterface.ExecuteSPIECInductorsTransformersAndCoils
                    (
                        request.TransformersType,
                        request.OperatingFrequencyMHz,
                        request.MaximumOperatingFrequencyMHz,
                        request.WorstCasePowerDissipationAtMaximumFrequencyW,
                        request.MaximumSupplyCurrentA,
                        request.NominalVoltage,
                        request.ThermalResistance,
                        request.AmbientTemperature,
                        request.LambdaRef
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
        [HttpGet]
        [Route("GetIECPreductionInductorsTransformersAndCoils")]
        public async Task<JsonResult> GetIECPreductionInductorsTransformersAndCoils()
        {
            try
            {
                var result = await _IECInterface.GetIECPreductionInductorsTransformersAndCoils();

                if (result == null || !result.Any())
                {
                    return new JsonResult(new { message = MessageInfo.Null });
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
        [Route("SaveInductorsTransformersAndCoils")]
        public async Task<JsonResult> SaveInductorsTransformersAndCoils(IECPreductionInductorsTransformersAndCoilsDto request)
        {
            try
            {
                var result = await _IECInterface.SaveInductorsTransformersAndCoils(request);
                return new JsonResult(new
                {
                    message = MessageInfo.Successfully,
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
        [HttpDelete]
        [Route("DeleteInductorsTransformersAndCoils")]
        public async Task<JsonResult> DeleteInductorsTransformersAndCoils(int Trid)
        {
            try
            {
                var result = await _IECInterface.DeleteInductorsTransformersAndCoils(Trid);
                return new JsonResult(new { message = MessageInfo.Deleted });
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
