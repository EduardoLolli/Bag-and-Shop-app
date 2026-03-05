using Bag_and_Shop_app.Application.DTOs.System;
using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
  public class StoreRepository : IStoreRepository
  {
    private readonly BagAndShopDBContext _context;
    public StoreRepository(BagAndShopDBContext context)
    {
      _context = context;
    }

    // public Task<SystemResponseDTO> AddStore(int CampaignId)
    // {
    // }

  }
}
