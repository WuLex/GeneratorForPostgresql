
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgresqlGenerator.Models.Dto
{
    public class EnrollmentDateGroupDto
    {
        public DateTime EnrollmentDate { get; set; }
        public int StudentCount { get; set; }
    }
}
