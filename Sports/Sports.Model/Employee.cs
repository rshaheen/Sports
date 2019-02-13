namespace Sports.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            BusinessUsers = new HashSet<BusinessUser>();
            EmploymentHistories = new HashSet<EmploymentHistory>();
            NotificationSettings = new HashSet<NotificationSetting>();
            WorkflowactionSettings = new HashSet<WorkflowactionSetting>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string PresentAddress { get; set; }

        [StringLength(200)]
        public string PermanentAddress { get; set; }

        [StringLength(100)]
        public string FatherName { get; set; }

        [StringLength(100)]
        public string MotherName { get; set; }

        [StringLength(50)]
        public string NationalId { get; set; }

        [StringLength(50)]
        public string PassportNo { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string OfficePhone { get; set; }

        [StringLength(50)]
        public string OfficeMobile { get; set; }

        [StringLength(50)]
        public string ResidentPhone { get; set; }

        [StringLength(50)]
        public string ResidentMobile { get; set; }

        [StringLength(10)]
        public string BloodGroup { get; set; }

        [StringLength(250)]
        public string PhotoPath { get; set; }

        [StringLength(50)]
        public string AuthenticationCode { get; set; }

        public double EmployeeTotalBillSubmitted { get; set; }

        public double EmployeeTotalBillPaidByMgt { get; set; }

        public double EmployeeTotalDue { get; set; }

        public DateTime? LastPaymentDate { get; set; }

        public double? LastPaidAmount { get; set; }

        [StringLength(20)]
        public string LastPaymentMedia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessUser> BusinessUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploymentHistory> EmploymentHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationSetting> NotificationSettings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkflowactionSetting> WorkflowactionSettings { get; set; }
    }
}
