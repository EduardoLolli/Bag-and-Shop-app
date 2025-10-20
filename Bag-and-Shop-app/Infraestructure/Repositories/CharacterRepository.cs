using Bag_and_Shop_app.Infraestructure.Data;
using BagAndShopApp.Domain.Interfaces;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class CharacterRepository: ICharacterRepository
    {
        private readonly BagAndShopDBContext _context;
        public CharacterRepository(BagAndShopDBContext bagAndShopDBContext)
        {
            _context = bagAndShopDBContext;
        }

    }

}