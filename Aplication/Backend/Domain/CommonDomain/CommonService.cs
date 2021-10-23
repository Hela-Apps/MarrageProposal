using AutoMapper;
using Domain.ViewModel;
using Entity.Models;
using Newtonsoft.Json;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CommonDomain
{
    public class CommonService : Profile, ICommonService
    {
        private readonly IVehicleCompanyRepository _companyRepository;
        private readonly IVehicleCategoryRepository _categoryRepository;
        private readonly IVehicleConditionRepository _conditionRepository;
        private readonly IDistrictRepository _districtRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IManuFacturedYearRepository _manuFacturedYearRepository;
        public CommonService(IVehicleCompanyRepository companyRepository,
            IVehicleCategoryRepository categoryRepository,
            IVehicleConditionRepository conditionRepository,
            IDistrictRepository districtRepository,
            ICityRepository cityRepository,
            IManuFacturedYearRepository manuFacturedYearRepository)
        {
            _companyRepository = companyRepository;
            _categoryRepository = categoryRepository;
            _conditionRepository = conditionRepository;
            _districtRepository = districtRepository;
            _cityRepository = cityRepository;
            _manuFacturedYearRepository = manuFacturedYearRepository;
        }

        public async Task<IEnumerable<VehicleCompany>> GetAllcompanies()
        {
            var companies = await _companyRepository.GetAll();
            return companies.Where(x => x.IsActive == true);
        }

        public async Task<IEnumerable<VehicleCategory>> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAll();
            return categories.Where(x => x.IsActive == true);
        }

        public async Task<IEnumerable<VehicleCondition>> GetAllConditions()
        {
            var conditions = await _conditionRepository.GetAll();
            return conditions.Where(x => x.IsActive == true);
        }

        public async Task<IEnumerable<District>> GetAllDistricts()
        {
            var conditions = await _districtRepository.GetAll();
            return conditions.Where(x => x.IsActive == true);
        }
        public async Task<IEnumerable<City>> GetAllCitiesbyDistrictId(int id)
        {
            var conditions = await _cityRepository.GetAllbyDistrictId(id);
            return conditions.Where(x => x.IsActive == true);
        }

        public async Task<IEnumerable<ManuFacturedYear>> GetAllYears()
        {
            var conditions = await _manuFacturedYearRepository.GetAll();
            return conditions.Where(x => x.IsActive == true);
        }
    }
}
