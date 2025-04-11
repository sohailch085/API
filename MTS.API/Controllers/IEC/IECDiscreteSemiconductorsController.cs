using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.IEC
{
    [Route("api/IECDiscreteSemiconductors")]
    [ApiController]
    public class IECDiscreteSemiconductorsController : ControllerBase
    {
        private readonly IECInterface _IECInterface;

        public IECDiscreteSemiconductorsController(IECInterface ecInterface)
        {
            _IECInterface = ecInterface;
        }
        //[HttpGet]
        //[Route("GetIECConstantsForTemperatureDependenceOfDiscreteSemiconductors")]
        //public JsonResult GetIECConstantsForTemperatureDependenceOfDiscreteSemiconductors()
        //{
        //    try
        //    {
        //        var result = _IECInterface.GetIECConstantsForTemperatureDependenceOfDiscreteSemiconductors();

        //        if (result == null || !result.Any())
        //        {
        //            return new JsonResult(new { message = MessageInfo.Null });
        //        }
        //        return new JsonResult(new
        //        {
        //            message = MessageInfo.Retrieved,
        //            data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {

        //        return new JsonResult(new
        //        {
        //            message = MessageInfo.Error + ex.Message
        //        });
        //    }
        //}
        [HttpGet]
        [Route("GetIECDiscreteSemiconductors")]
        public JsonResult GetIECDiscreteSemiconductors()
        {
            try
            {
                var result = _IECInterface.GetIECDiscreteSemiconductors();

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
        [HttpGet]
        [Route("GetIECDiscreteSemiconductorsSubcategory")]
        public async Task<ActionResult> GetIECDiscreteSemiconductorsSubcategory(int SubComponentId)
        {
            try
            {
                var result = await _IECInterface.GetIECDiscreteSemiconductorsSubcategory(SubComponentId);

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
        [Route("GetExecuteIECDiscreteSemiconductors")]
        public async Task<JsonResult> GetExecuteIECDiscreteSemiconductors(DiscreteSemiconductorsCollectionDto collectionDto)
        {
            try
            {
                var Result = await _IECInterface.ExecuteIECDiscreteSemiconductors
               (
                   collectionDto.SUBCATEGORYID,
                   collectionDto.TYPESID,
                   collectionDto.RatedVoltageInV,
                   collectionDto.NominalVoltage,
                   collectionDto.ThermalResistance,
                   collectionDto.AmbientTemperature,
                   collectionDto.MaximumSupplyCurrentA,
                   collectionDto.WorstCasePowerDissipationAtMaximumFrequencyW,
                   collectionDto.OperatingFrequencyMHz,
                   collectionDto.MaximumOperatingFrequencyMHz,
                   collectionDto.OperatingVoltageInV,
                   collectionDto.LambdaRef
                );
                return new JsonResult(new
                {
                    message = MessageInfo.Retrieved,
                    data = Result
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
        [Route("SaveDiscreateSemiconductors")]
        public async Task<JsonResult> SaveDiscreateSemiconductors(IECDiscreteSemiconductorsCollectionDto collectionDto)
        {
            try
            {
                var result = await _IECInterface.SaveDiscreteSemiconductors(collectionDto);
                if (result == false)
                {
                    return new JsonResult(new { message = MessageInfo.Null });
                }
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
        [HttpGet]
        [Route("GetPreductionDiscreteSemiconductors")]
        public async Task<JsonResult> GetPreductionDiscreteSemiconductors()
        {
            try
            {
                var result = await _IECInterface.GetPreductionDiscreteSemiconductors();
                if (result == null || !result.Any())
                {
                    return new JsonResult
                    (new
                    {
                        message = MessageInfo.Null
                    });
                }
                return new JsonResult
                    (new
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
        [HttpDelete]
        [Route("DeleteDiscreteSemiconductors")]
        public async Task<JsonResult> DeleteDiscreteSemiconductors(int Trid)
        {
            try
            {
                var result = await _IECInterface.DeleteDiscreteSemiconductors(Trid);
                return new JsonResult(new
                {
                    message = MessageInfo.Deleted,
                    data = result
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new
                {
                    message = MessageInfo.Error + ex.Message,
                    data = false
                });
            }
        }
    }
}
