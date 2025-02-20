﻿using Rx.Domain.DTOs.Tenant.Bill;

namespace Rx.Domain.Interfaces.Tenant
{
    public interface IBillingService
    {
        Task<BillDto> CreateBill (Guid subscriptionId,BillForCreationDto billForCreationDto);
    }
}
