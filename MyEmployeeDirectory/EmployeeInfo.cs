namespace MyEmployeeDirectory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeInfo")]
    public partial class EmployeeInfo
    {
        public int Id { get; set; }

        public string EmployeeName { get; set; }

        [StringLength(50)]
        public string JobTitle { get; set; }
    }
}
