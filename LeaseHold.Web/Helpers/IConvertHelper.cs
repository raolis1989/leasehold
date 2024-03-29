﻿using System.Threading.Tasks;
using LeaseHold.Web.Data.Entities;
using LeaseHold.Web.Models;

namespace LeaseHold.Web.Helpers
{
    public interface IConvertHelper
    {
        Task<Property> ToProperty(PropertyViewModel model, bool isNew);

        PropertyViewModel ToPropertyViewModel(Property property);

        Task<Contract> ToContractAsync(ContractViewModel model, bool isNew);
        ContractViewModel ToContractViewModel(Contract contract);
    }
}