//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prbd_1718_presences_g27
{
    using System;
    using System.Collections.Generic;
    
    public partial class Certificate
    {
        public int Id { get; set; }
        public System.DateTime Startdate { get; set; }
        public System.DateTime Finishdate { get; set; }
    
        public virtual Student Student { get; set; }
    }
}