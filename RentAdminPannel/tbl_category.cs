//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentAdminPannel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_category()
        {
            this.tbl_product = new HashSet<tbl_product>();
            this.tbl_subcategory = new HashSet<tbl_subcategory>();
            entryby = "shafi";


        }
    
        [Key]
        public long categoryid { get; set; }
        
        public string categoryname { get; set; }
        public string categorydescription { get; set; }
        
        public string entryby { get; set; } 

        public Nullable<System.DateTime> entrydate { get; set; }
        public Nullable<byte> isactive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_product> tbl_product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subcategory> tbl_subcategory { get; set; }
    }
}
