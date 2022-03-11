using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSchedulingDotNet5.Helper
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Patient = "Patient";
        public static string Doctor = "Doctor";

        public static List<SelectListItem> GetRolesForDropdown()
        {
            return new List<SelectListItem
            {
                new SelectListItem{Value="Admin", Text=Helper.Admin},
                new SelectListItem{Value="Patient", Text=Helper.Patient},
                new SelectListItem{Value="Doctor", Text=Helper.Doctor}
            }
        }
    }
}
