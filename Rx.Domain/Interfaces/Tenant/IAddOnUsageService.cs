﻿using Rx.Domain.DTOs.Tenant.AddOn;
using Rx.Domain.DTOs.Tenant.AddOnUsage;

namespace Rx.Domain.Interfaces.Tenant;

public interface IAddOnUsageService
{
    Task<AddOnUsageDto> CreateAddOnUsage(Guid subscriptionId,Guid addOnId,AddOnUsageForCreationDto addOnUsageForCreationDto);
}