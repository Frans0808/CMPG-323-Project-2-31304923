using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace IOTDeviceManagement.Models
{
    public partial class Device
    {
        [DisplayName("Device ID")]
        public Guid DeviceId { get; set; }
        [DisplayName("Device Name")]
        public string DeviceName { get; set; }
        [DisplayName("Category ID")]
        public Guid CategoryId { get; set; }
        [DisplayName("Zone ID")]
        public Guid ZoneId { get; set; }
        [DisplayName("Status")]
        public string Status { get; set; }
        [DisplayName("Is Active")]
        public bool IsActive { get; set; }
        [DisplayName("Date Created")]
        public DateTime DateCreated { get; set; }

        [DisplayName("Category")]
        public virtual Category Category { get; set; }
        [DisplayName("Zone")]
        public virtual System.Security.Policy.Zone Zone { get; set; }
    }
}
