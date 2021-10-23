using System;
using System.Collections.Generic;
using Entity.Models;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Linq.Expressions;
using SmartERP.Repository.Interfaces;

namespace Repository.Interfaces
{
    public interface IVehicleCompanyRepository :IAsyncRepository<VehicleCompany>
    {
        //Task<VehicleCompany> GetById(long id);
        //Task<VehicleCompany> FirstOrDefault(Expression<Func<VehicleCompany, bool>> predicate);

        //Task<int> Add(VehicleCompany entity);
        //Task Update(VehicleCompany entity);
        //Task Remove(VehicleCompany entity);

        //Task<IEnumerable<VehicleCompany>> GetAll();
        //Task<IEnumerable<VehicleCompany>> GetWhere(Expression<Func<VehicleCompany, bool>> predicate);

        //Task<int> CountAll();
        //Task<int> CountWhere(Expression<Func<VehicleCompany, bool>> predicate);
    }
}
