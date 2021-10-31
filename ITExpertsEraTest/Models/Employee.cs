using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITExpertsEraTest.Models
{
    // Employee Model Class Example2.
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public string Department { get; set; }
    }
}
