using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyManagement.Model.Entities
{
    public class ActivityLog
    {
        public Guid LogId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Action { get; set; }
        public Guid IncidentId { get; set; }
    }
}
