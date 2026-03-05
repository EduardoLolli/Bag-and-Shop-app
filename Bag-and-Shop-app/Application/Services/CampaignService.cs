using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Application.DTOs.System;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Nelibur.ObjectMapper;

namespace Bag_and_Shop_app.Application.Services
{

  public class CampaignService : ICampaignService
  {
    private readonly ICampaignRepository _campaignRepository;
    private readonly IUserRepository _userRepository;
    private readonly IStoreService _storeService;
    public CampaignService(
        ICampaignRepository campaignRepository,
        IUserRepository userRepository,
        IStoreService storeService
        )
    {
      _campaignRepository = campaignRepository;
      _userRepository = userRepository;
      _storeService = storeService;
    }

    public async Task<CreateCampaignResponseDTO> CreateCampaign(Campaign campaign)
    {
      try
      {

        CreateCampaignResponseDTO camp = TinyMapper.Map<CreateCampaignResponseDTO>(campaign);
        // Store store = await _storeService.CreateStore(camp.Id);


        return camp;

      }
      catch (Exception ex)
      {
        throw new Exception("Erro ao criar campanha: " + ex.Message);
      }
    }

    public async Task<string> GenerateCampaignCode()
    {
      try
      {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        string code;
        bool codeExists;

        do
        {
          code = new string(Enumerable.Repeat(chars, 12)
               .Select(s => s[random.Next(s.Length)]).ToArray());
          codeExists = await _campaignRepository.VerifyCode(code);
        } while (codeExists);
        return code;
      }
      catch (Exception ex)
      {
        throw new Exception("Erro ao gerar código da campanha: " + ex.Message);
      }
    }

    // public Task<CampaignResponseDTO> GetCampaignByCode(string campaignCode)
    // {

    //   return _campaignRepository.GetCampaignByCCode(campaignCode);

    // }

    // public Task<List<CampaignResponseDTO>> GetCampaignByMasterId(int masterId)
    // {
    //   return _campaignRepository.GetCampaignByMasterId(masterId);
    // }

  }
}
