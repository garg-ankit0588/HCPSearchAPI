using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCPModels
{
    public class HCPModel: SpecialityModel
    {
        public int HCPId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public SpecialityModel Speciality { get; set; }
    }
}
    