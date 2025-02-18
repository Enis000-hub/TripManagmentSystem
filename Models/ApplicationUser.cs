using Microsoft.AspNetCore.Identity;
using TripManagmentSystem.Models;

namespace TripManagmentSystem.Models
{
    

     // Трябва да съответства на пространството от имена на проекта ти
    
        public class ApplicationUser : IdentityUser
        {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumberCustom { get; set; }  
        public string EmailCustom { get; set; }        

    }
    

}
