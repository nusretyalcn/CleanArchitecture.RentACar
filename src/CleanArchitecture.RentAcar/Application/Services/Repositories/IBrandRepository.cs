using Core.Persistence.Repository;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IBrandRepository:IAsyncRepository<Brand,Guid>
{
    
}