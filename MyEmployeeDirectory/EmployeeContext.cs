namespace MyEmployeeDirectory
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("name=ModelEmployeeInfo")
        {
        }

        public virtual DbSet<EmployeeInfo> EmployeeInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
