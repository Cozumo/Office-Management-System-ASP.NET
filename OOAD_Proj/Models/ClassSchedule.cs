//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOAD_Proj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class ClassSchedule
    {
        public int clsScd { get; set; }
        public Nullable<int> Course { get; set; }
        public Nullable<System.DateTime> scd_date { get; set; }
        public Nullable<int> S_semester { get; set; }
    
        public virtual Course Course1 { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
