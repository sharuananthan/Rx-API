﻿using Rx.Domain.DTOs.Tenant.OrganizationCustomer;

namespace Rx.Domain.Interfaces.Tenant
{
    public interface IOrganizationCustomerService
    {
        Task<CustomerStatsDto> GetCustomerStats();
        Task<IEnumerable<OrganizationCustomerDto>> GetCustomers();

        Task<OrganizationCustomerDto> GetCustomerById(Guid id);

        Task<OrganizationCustomerDto> AddCustomer(OrganizationCustomerForCreationDto organizationCustomerForCreationDto);

    }
}
