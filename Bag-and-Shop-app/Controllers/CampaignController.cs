using System.Security.Permissions;
using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using BagAndShopApp.Application.DTOs.Character;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nelibur.ObjectMapper;

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
        Campaign newCampaign = TinyMapper.Map<Campaign>(dto);
        newCampaign.Campaign_code = await _campaignService.GenerateCampaignCode();
        // CampaignResponseDTO campaignResponse = await _campaignService.CreateCampaign(newCampaign);
        return Ok(new
        {
          error = false,
          message = "Campanha criada com sucesso",
          data = true
          // campaignResponse
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

    [HttpGet("v1/getCampaignsByMasterId/{masterId}")]
    public async Task<ActionResult<List<CampaignResponseDTO>>> GetCampaignByMasterId(int masterId)
    {
      try
      {
        List<CampaignResponseDTO> campaigns = await _campaignService.GetCampaignByMasterId(masterId);
        return Ok(new
        {
          error = false,
          message = "Campanhas obtidas com sucesso",
          data = campaigns
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

    [HttpPost("v1/findCampaignByCode")]
    public async Task<ActionResult<CampaignResponseDTO>> FindCampaignByCode([FromBody] CampaignCodeRequestDTO dto)
    {

      try
      {
        CampaignResponseDTO campaign = await _campaignService.GetCampaignByCode(dto.CampaignCode);


        return Ok(new
        {
          error = false,
          message = "Campanha obtida com sucesso",
          data = campaign
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


    [HttpPost("v1/getMasterShieldInfo")]
    public async Task<ActionResult<CampaignResponseDTO>> getMasterShieldInfo([FromBody] CampaignCodeRequestDTO dto)
    {

      try
      {
        CampaignResponseDTO campaign = await _campaignService.GetCampaignByCode(dto.CampaignCode);


        return Ok(new
        {
          error = false,
          message = "Dados da campanha recuperados com sucesso!",
          data = campaign
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
