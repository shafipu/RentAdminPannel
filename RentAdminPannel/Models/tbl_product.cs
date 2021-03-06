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
    public partial class tbl_product
    {
        [Key]
        public long productid { get; set; }
        public string productcode { get; set; }
        public string productname { get; set; }
        public Nullable<long> fk_categoryid { get; set; }
        public Nullable<long> fk_subcategoryid { get; set; }
        public Nullable<long> fk_userid { get; set; }
        public string productdescription { get; set; }
        public string dailyrent { get; set; }
        public string monthlyrent { get; set; }
        public string prodcutmake { get; set; }
        public string productmodel { get; set; }
        public Nullable<System.DateTime> entrydate { get; set; }
        public Nullable<double> latitude { get; set; }
        public Nullable<double> longitude { get; set; }
        public string availablestate { get; set; }
        public string availablecity { get; set; }
        public string availablezipcode { get; set; }
        public Nullable<long> fk_productstatus { get; set; }
        public Nullable<byte> isactive { get; set; }
        public Nullable<byte> isapproved { get; set; }
        public string videolink { get; set; }
        public string photolink1 { get; set; }
        public string photolink2 { get; set; }
        public string photolink3 { get; set; }
        public string photolink4 { get; set; }
    
        public virtual tbl_category tbl_category { get; set; }
        public virtual tbl_productstatus tbl_productstatus { get; set; }
        public virtual tbl_subcategory tbl_subcategory { get; set; }
        public virtual tbl_usermaster tbl_usermaster { get; set; }
    }
}
