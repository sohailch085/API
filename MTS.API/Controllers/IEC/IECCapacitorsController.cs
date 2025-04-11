using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO.Collection;

namespace MTS.API.Controllers.IEC
{
    [Route("api/IECCapacitors")]
    [ApiController]
    public class IECCapacitorsController : ControllerBase
    {
        private readonly IECInterface _IECInterface;
        public IECCapacitorsController(IECInterface ecInterface)
        {
            _IECInterface = ecInterface;
        }

        [HttpGet]
        [Route("GetCapacitors")]
        public async Task<JsonResult> GetIECCapacitors()
        {
            try
            {
                var result = await _IECInterface.GetIECCapacitors();

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
        [Route("GetIECCapacitorsTypes")]
        public async Task<JsonResult> GetIECCapacitorsTypes(int CATEGORYID)
        {
            try
            {
                var result = await _IECInterface.GetIECCapacitorsTypes(CATEGORYID);

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
        public async Task<JsonResult> ExecuteStoredProcedure(IECCapacitorCollectionDto request)
        {
            try
            {
                var result = await _IECInterface.ExecuteStoredProcedure
                    (
                        request.SUBCATEGORYID,
                        request.TYPEID,
                        request.OPERATINGVOLTAGEINV,
                        request.RATEDVOLTAGEINV,
                        request.AVERAGEACTUALTEMPERATURE,
                        request.LAMBDAREF
                    );

                if (result == null || !result.Any())
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
        [HttpPost]
        [Route("InsertIECCapacitor")]
        public async Task<JsonResult> InsertIECCapacitor(IECPreductionCapacitorCollectionDto capacitorCollectionDto)
        {
            try
            {

                var result = await _IECInterface.SaveCapacitor(capacitorCollectionDto);
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
        [HttpDelete]
        [Route("DeleteIECCapacitor")]
        public async Task<JsonResult> DeleteIECCapacitor(long Trid)
        {
            try
            {
                var result = await _IECInterface.DeleteCapacitor(Trid);

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
                    message = MessageInfo.Error + ex.Message

                });
            }
        }
        [HttpPost]
        [Route("GetAllPreductionCapacitor")]
        public async Task<JsonResult> GetAllPreductionCapacitor()
        {
            try
            {
                var result = await _IECInterface.GetIECPreductionCapacitor();
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
