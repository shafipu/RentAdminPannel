//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentAdminPannel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class tbl_rollmaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_rollmaster()
        {
            this.tbl_usermaster = new HashSet<tbl_usermaster>();
        }
      [Key]
        public long rollid { get; set; }
        public string rollname { get; set; }
        public string rolldescription { get; set; }
        public Nullable<byte> isActive { get; set; }
        public string entryby { get; set; }
        public Nullable<System.DateTime> entrydate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_usermaster> tbl_usermaster { get; set; }
    }
}
