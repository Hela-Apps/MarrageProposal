using Entity.Models;
using SmartERP.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IVehicleConditionRepository : IAsyncRepository<VehicleCondition>
    {
    }
}
