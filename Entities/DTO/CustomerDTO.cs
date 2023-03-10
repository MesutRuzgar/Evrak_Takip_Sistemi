using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class CustomerDTO :IDto
    {
        public int Id { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public string CompanyName { get; set; }       
        public string? TaxPlateYear { get; set; }
        public DateTime? ActivityCertificateDate { get; set; }
        public DateTime? SignatureCircularDate { get; set; }
        public string? CompanyOfficials { get; set; }
    }
}
