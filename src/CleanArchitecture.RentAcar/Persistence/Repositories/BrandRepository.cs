using Application.Services.Repositories;
using Core.Persistence.Repository;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories;

public class BrandRepository:EfRepositoryBase<Brand,Guid,BaseDbContext>,IBrandRepository
{
    public BrandRepository(BaseDbContext context) : base(context)
    {
    }
}