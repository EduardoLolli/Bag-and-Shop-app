using Bag_and_Shop_app.Application.DTOs.System;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;

namespace Bag_and_Shop_app.Application.Services
{
  public class StoreService : IStoreService
  {
    private readonly IStoreRepository _storeRepository;
    public StoreService(IStoreRepository storeRepository)
    {
      _storeRepository = storeRepository;
    }


    // public Task<Store> CreateStore(int CampaignId)
    // {

    //   Store store = _storeRepository.AddStore(CampaignId);

    //   return store;
    // }

  }
}
