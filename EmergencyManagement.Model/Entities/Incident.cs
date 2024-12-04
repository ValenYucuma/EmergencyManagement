using EmergencyManagement.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyManagement.Model.Entities
{
    public class Incident
    {
        public Guid IncidentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public SeverityLevel Severity { get; set; }
        public IncidentStatus Status { get; set; }
    }
}
