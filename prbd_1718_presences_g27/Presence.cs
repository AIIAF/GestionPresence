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
    
    public partial class Presence
    {
        public int Student { get; set; }
        public int Courseoccurence { get; set; }
        public short Present { get; set; }
    
        public virtual Courseoccurrence Courseoccurrence { get; set; }
        public virtual Student Student1 { get; set; }
    }
}
