using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Application.DTOs.System;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;

namespace Bag_and_Shop_app.Application.Services
{

    public class CampaignService : ICampaignService
    {
        private readonly ICampaignRepository _campaignRepository;
        private readonly IStoreRepository _storeRepository;
        private readonly IUserRepository _userRepository;
        private readonly ISystemRepository _systemRepository;
        public CampaignService(
            ICampaignRepository campaignRepository, 
            IStoreRepository storeRepository, 
            ISystemRepository systemRepository,
            IUserRepository userRepository)
        {
            _campaignRepository = campaignRepository;
            _storeRepository = storeRepository;
            _systemRepository = systemRepository;
            _userRepository = userRepository;
        }

        public async Task<CampaignResponseDTO> CreateCampaign(Campaign campaign)
        {
            try
            {
                SystemResponseDTO? system = await _systemRepository.GetSystemById(campaign.SystemId) ?? throw new Exception("Sistema de RPG não encontrado");
                User? master = await _userRepository.FindUserById(campaign.MasterId) ?? throw new Exception("Mestre da campanha não encontrado");
                CampaignResponseDTO createdCampaign = await _campaignRepository.AddCampaign(campaign);
                Store store = new()
                {
                    Name = "Loja",
                    CampaignId = createdCampaign.Id
                };

                Store storeCreated = await _storeRepository.AddStore(store);

                return createdCampaign;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar campanha -> " + ex.Message);
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
