using Application.Features.Brands.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Rules;

public class BrandBussinesRules : BaseBusinessRules
{
    private readonly IBrandRepository _brandRepository;

    public BrandBussinesRules(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task BrandNameCannotBeDublicatedWhenInserted(string name)
    {
        Brand? result = await _brandRepository.GetAsync(predicate: b => b.name.ToLower() == name.ToLower());

        if (result != null)
        {
            throw new BusinessException(BrandsMessages.BrandNameExists);
        }
    }
}
