﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace IOTDeviceManagement.Models
{
    public partial class Category
    {
        public Category()
        {
            Device = new HashSet<Device>();
        }

        [DisplayName("Category ID")]
        public Guid CategoryId { get; set; }
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
        [DisplayName("Category Description")]
        public string CategoryDescription { get; set; }
        [DisplayName("Category Date Created")]
        public DateTime DateCreated { get; set; }

        [DisplayName("Device")]
        public virtual ICollection<Device> Device { get; set; }
    }
}
