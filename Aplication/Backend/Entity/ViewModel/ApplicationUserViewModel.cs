using Entity.Mappings;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.ViewModel
{
    public class ApplicationUserViewModel: IMapBoth<ApplicationUser>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int CityId { get; set; }
    }
}
