using Domain.ViewModel;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CommonDomain
{
    public interface ICommonService
    {
        Task<IEnumerable<VehicleCompany>> GetAllcompanies();
        Task<IEnumerable<VehicleCategory>> GetAllCategories();
        Task<IEnumerable<VehicleCondition>> GetAllConditions();
        Task<IEnumerable<District>> GetAllDistricts();
        Task<IEnumerable<City>> GetAllCitiesbyDistrictId(int id);
        Task<IEnumerable<ManuFacturedYear>> GetAllYears();
    }
}
