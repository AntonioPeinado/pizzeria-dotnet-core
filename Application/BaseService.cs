using API.Infraestructure;
using System;

namespace API.Application
{
    public class BaseService : IDisposable
    {
        private readonly IUnitOfWork _uow;
        public BaseService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public void Dispose()
        {
            _uow.Dispose();
        }

    }
}