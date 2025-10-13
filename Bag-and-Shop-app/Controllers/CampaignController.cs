using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bag_and_Shop_app.Controllers
{
    [Authorize]
    [Route("api/campaing")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly ICampaignService _campaignService;
        public CampaignController(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        [HttpPost("v1/CreateCampaign")]
        public async Task<ActionResult<CampaignResponseDTO>> CreateCampaign([FromBody] CampaignRequestDTO dto)
        {
            try
            {
                Campaign campaign = new Campaign
                {
                    Name = dto.Name,
                    SystemId = dto.SystemId,
                    CampaignCode = await _campaignService.GenerateCampaignCode(),
                    MasterId = dto.MasterId
                };
                CampaignResponseDTO newCampaign = await _campaignService.CreateCampaign(campaign);
                return Ok(new
                {
                    error = false,
                    message = "Campanha criada com sucesso",
                    data = newCampaign
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    error = true,
                    message = ex.Message
                });
            }
        }
    }
}
