using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.IEC
{
    [Route("api/IECOptoelectronicComponents")]
    [ApiController]
    public class IECOptoelectronicComponentsController : ControllerBase
    {
        private readonly IECInterface _IECInterface;
        public IECOptoelectronicComponentsController(IECInterface ecInterface)
        {
            _IECInterface = ecInterface;
        }
        //[HttpGet]
        //[Route("GetIECConstantsForTemperatureDependenceOfOptoelectronicComponents")]
        //public JsonResult GetIECConstantsForTemperatureDependenceOfOptoelectronicComponents()
        //{
        //    try
        //    {
        //        var result = _IECInterface.GetIECConstantsForTemperatureDependenceOfOptoelectronicComponents();

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
        [Route("GetIECOptoelectronicComponentsTypes")]
        public JsonResult GetIECOptoelectronicComponentsTypes(int SubCategoryId)
        {
            try
            {
                var result = _IECInterface.GetIECOptoelectronicComponentsTypes(SubCategoryId);

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
        [Route("GetIECOptoelectronicComponentsSubCategory")]
        public async Task<JsonResult> GetIECOptoelectronicComponentsSubCategory()
        {
            try
            {
                var result = await _IECInterface.GetIECOptoelectronicComponentsSubCategory();

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
        [Route("ExecuteStoredProcedure")]
        public async Task<JsonResult> ExecuteStoredProcedure(IECOptoelectronicComponentCollectionDto request)
        {
            try
            {
                var result = await _IECInterface.ExecuteIECOptoelectronicComponents
                    (
                        request.TypesId,
                        request.SubCategoryId,
                        request.OperatingVoltageInV,
                        request.ReferenceVoltageInV,
                        request.RatedVoltageInV,
                        request.Fop,
                        request.Fmax,
                        request.Pfwc,
                        request.MaximumSupplyCurrentA,
                        request.NominalVoltage,
                        request.ThermalResistance,
                        request.AmbientTemperature,
                        request.LambdaRef
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
        [HttpGet]
        [Route("GetPreductionOptoelectronicComponents")]
        public JsonResult GetPreductionOptoelectronicComponents()
        {
            try
            {
                var result = _IECInterface.GetPreductionOptoelectronicComponents();

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
        [Route("SaveOptoelectronicComponent")]
        public async Task<JsonResult> SaveOptoelectronicComponent(IECPreductionOptoelectronicComponentDto request)
        {
            try
            {
                var result = await _IECInterface.SaveOptoelectronicComponent(request);
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
        [Route("DeleteOptoelectronicComponent")]
        public async Task<JsonResult> DeleteOptoelectronicComponent(int Trid)
        {
            try
            {
                var result = await _IECInterface.DeleteOptoelectronicComponent(Trid);
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
