using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.IEC
{
    [Route("api/IECIntegratedSemiconductorCircuits")]
    [ApiController]
    public class IECIntegratedSemiconductorCircuitsController : ControllerBase
    {
        private readonly IECInterface _IECInterface;
        public IECIntegratedSemiconductorCircuitsController(IECInterface ecInterface)
        {
            _IECInterface = ecInterface;
        }
        [HttpGet]
        [Route("GetIECTypeComponent")]
        public async Task<ActionResult> GetIECTypeComponent()
        {
            try
            {
                var result = await _IECInterface.GetIECTypeComponent();

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
        [Route("GetIECConstantForVoltageDependence")]
        public async Task<ActionResult> GetIECConstantForVoltageDependence()
        {
            try
            {
                var result = await _IECInterface.GetIECConstantForVoltageDependence();

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
        [Route("GetIECTypeComponentSubCategory")]
        public async Task<ActionResult> GetIECTypeComponentSubCategory(int SubComponentId)
        {
            try
            {
                var result = await _IECInterface.GetIECTypeComponentSubCategory(SubComponentId);

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
        [Route("GetIECConstantsForTemperatureDependence")]
        public async Task<ActionResult> GetIECConstantsForTemperatureDependence()
        {
            try
            {
                var result = await _IECInterface.GetIECConstantsForTemperatureDependence();

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
        [Route("ExecuteSpIECIntegratedSemiconductorCircuits")]
        public async Task<ActionResult> ExecuteSpIECIntegratedSemiconductorCircuits([FromBody] IECIntegratedSemiconductorCircuitsCollectionDto request)
        {
            try
            {
                var result = await _IECInterface.ExecuteSpIECIntegratedSemiconductorCircuits(
                request.CircuitType,
                request.SubComponent,
                request.ConstantsType,
                request.OperatingVoltageInV,
                request.RatedVoltageInV,
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
        [Route("GetPreductionIntegratedSemiconductorCircuits")]
        public async Task<JsonResult> GetPreductionIntegratedSemiconductorCircuits()
        {
            try
            {
                var result = await _IECInterface.GetPreductionIntegratedSemiconductorCircuits();

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
        [Route("SaveIntegratedSemiconductorCircuits")]
        public async Task<JsonResult> SaveIntegratedSemiconductorCircuits(IECPreductionIntegratedSemiconductorCircuitsDto request)
        {
            try
            {
                var result = await _IECInterface.SaveIntegratedSemiconductorCircuits(request);
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
        [Route("DeleteIntegratedSemiconductorCircuits")]
        public async Task<JsonResult> DeleteIntegratedSemiconductorCircuits(int Trid)
        {
            try
            {
                var result = await _IECInterface.DeleteIntegratedSemiconductorCircuits(Trid);
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
