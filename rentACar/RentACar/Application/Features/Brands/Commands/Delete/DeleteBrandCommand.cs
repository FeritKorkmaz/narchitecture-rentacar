using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Caching;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Delete;

public class DeleteBrandCommand : IRequest<DeletedBrandResponse>, ICacheRemoverRequest
{
    public Guid Id { get; set; }
    public string? CacheKey => "";

    public string? CacheGroupKey => "GetBrands";

    public bool BypassCache => false;

    public class DeleteBrandCommanHandler  : IRequestHandler<DeleteBrandCommand ,DeletedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;

        private readonly IMapper _mapper;
        public DeleteBrandCommanHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<DeletedBrandResponse> Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);
            await _brandRepository.DeleteAsync(brand);
            DeletedBrandResponse deletedBrandResponse = _mapper.Map<DeletedBrandResponse>(brand);
            return deletedBrandResponse;
        }



    }


}
