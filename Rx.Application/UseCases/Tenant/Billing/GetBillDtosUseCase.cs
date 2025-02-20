﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Rx.Domain.DTOs.Tenant.Bill;
using Rx.Domain.Interfaces.DbContext;

namespace Rx.Application.UseCases.Tenant.Billing;

public record GetBillDtosUseCase(Guid SubscriptionId):IRequest<IEnumerable<BillDto>>;

public class GetBillDtosUseCaseHandler : IRequestHandler<GetBillDtosUseCase, IEnumerable<BillDto>>
{
    private readonly ITenantDbContext _tenantDbContext;
    private readonly IMapper _mapper;

    public GetBillDtosUseCaseHandler(ITenantDbContext tenantDbContext,IMapper mapper)
    {
        _tenantDbContext = tenantDbContext;
        _mapper = mapper;
    }
    public async Task<IEnumerable<BillDto>> Handle(GetBillDtosUseCase request, CancellationToken cancellationToken)
    {
        
        var bills =await _tenantDbContext.Bills.Where(x => x.SubscriptionId == request.SubscriptionId).ToListAsync(cancellationToken);
        return _mapper.Map<IEnumerable<BillDto>>(bills);
    }
}


