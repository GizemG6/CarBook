using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingQueryHandler : IRequestHandler<GetCarPricingQuery, List<GetCarPricingQueryResult>>
    {
        private readonly ICarPricingRepository _repository;

        public GetCarPricingQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarPricingQueryResult>> Handle(GetCarPricingQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarsWithPricings();
            return values.Select(p => new GetCarPricingQueryResult
            {
                CarId = p.CarId,
                Amount = p.Amount,
                CarPricingId = p.CarPricingId,
                Brand = p.Car.Brand.Name,
                CoverImageUrl = p.Car.CoverImageUrl,
                Model = p.Car.Model
            }).ToList();
        }
    }
}
