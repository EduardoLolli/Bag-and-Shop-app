using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Domain.Entities;
using Nelibur.ObjectMapper;

public static class TinyMapperConfig
{
    public static void RegisterBindings()
    {
        TinyMapper.Bind<CreateCampaignDTO, Campaign>();
        TinyMapper.Bind<Campaign, CreateCampaignResponseDTO>();
        // TinyMapper.Bind<>();
        // TinyMapper.Bind<>();
        // TinyMapper.Bind<>();
    }
}
