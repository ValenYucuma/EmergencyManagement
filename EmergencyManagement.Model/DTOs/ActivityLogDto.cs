using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyManagement.Model.DTOs
{
    public class ActivityLogDto
    {
        public DateTime Timestamp { get; set; }
        public string Action { get; set; }
    }
}
