using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;

namespace Bag_and_Shop_app.Application.Services
{

    public class CampaignService : ICampaignService
    {
        private readonly ICampaignRepository _campaignRepository;
        private readonly IStoreRepository _storeRepository;
        public CampaignService(ICampaignRepository campaignRepository, IStoreRepository storeRepository)
        {
            _campaignRepository = campaignRepository;
            _storeRepository = storeRepository;
        }

        public async Task<CampaignResponseDTO> CreateCampaign(Campaign campaign)
        {
            try
            {
                CampaignResponseDTO createdCampaign = await _campaignRepository.AddCampaign(campaign);
                Store store = new Store
                {
                    Name = "Loja",
                    CampaignId = createdCampaign.Id
                };
                Store storeCreated = await _storeRepository.AddStore(store);

                return createdCampaign;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar campanha: " + ex.Message);
            }
        }

        public async Task<string> GenerateCampaignCode()
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

        public Task<CampaignResponseDTO> GetCampaignByCode(string campaignCode)
        {

            return _campaignRepository.GetCampaignByCCode(campaignCode);

        }

        public Task<List<CampaignResponseDTO>> GetCampaignByMasterId(int masterId)
        {
            return _campaignRepository.GetCampaignByMasterId(masterId);
        }

    }
}
