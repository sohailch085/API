using Microsoft.AspNetCore.Mvc;
using MTS_BAL.InterfaceServices;
using MTS_COMMON.Message;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.Entities.IEC;

namespace MTS.API.Controllers.IEC
{
    [Route("api/IECResistorsAndResistorNetworks")]
    [ApiController]
    public class IECResistorsAndResistorNetworksController : ControllerBase
    {

        private readonly IECInterface _IECInterface;
        public IECResistorsAndResistorNetworksController(IECInterface ecinterface)
        {
            _IECInterface = ecinterface;
        }
        [HttpGet]
        [Route("GetIECResistorsAndResistorNetworks")]
        public async Task<ActionResult> GetIECResistorsAndResistorNetworks()
        {
            try
            {
                var result = await _IECInterface.GetIECResistorsAndResistorNetworks();

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
        [Route("GetIECResistorsAndResistorNetworksInputType")]
        public async Task<ActionResult> GetIECResistorsAndResistorNetworksInputType()
        {
            try
            {
                var result = await _IECInterface.GetIECResistorsAndResistorNetworksInputType();

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
        [Route("ExecuteIECResistorsAndResistorNetworks")]
        public async Task<ActionResult> ExecuteIECResistorsAndResistorNetworks([FromBody] IECResistorsAndResistorNetworksCollectionDto request)
        {
            try
            {
                var result = await _IECInterface.ExecuteIECResistorsAndResistorNetworks
                    (
                        request.ResistorType,
                        request.InputType,
                        request.OperatingTemperature,
                        request.ThetaMax,
                        request.AmbiantTemperature,
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
        [Route("GetResistorsAndResistorNetworks")]
        public async Task<JsonResult> GetResistorsAndResistorNetworks()
        {
            try
            {
                var result = await _IECInterface.GetResistorsAndResistorNetworks();

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
        [Route("SaveResistorsAndResistorNetworks")]
        public async Task<JsonResult> SaveResistorsAndResistorNetworks(IECPreductionResistorsAndResistorNetworksDto request)
        {
            try
            {
                var result = await _IECInterface.SaveResistorsAndResistorNetworks(request);
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
        [Route("DeleteResistorsAndResistorNetworks")]
        public async Task<JsonResult> DeleteResistorsAndResistorNetworks(int Trid)
        {
            try
            {
                var result = await _IECInterface.DeleteResistorsAndResistorNetworks(Trid);
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
