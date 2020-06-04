using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;

namespace Store.Tests.Repositories
{
    public class FakeOrderReposiory : IOrderRepository
    {
        public void Save(Order order){ }
    }
}