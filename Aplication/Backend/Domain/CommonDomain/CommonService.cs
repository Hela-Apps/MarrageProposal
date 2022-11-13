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
       
        private readonly IDistrictRepository _districtRepository;
        private readonly ICityRepository _cityRepository;
        public CommonService(          IDistrictRepository districtRepository,
            ICityRepository cityRepository)
        {
         
            _districtRepository = districtRepository;
            _cityRepository = cityRepository;
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
       
    }
}
