//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlashDouble.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photographer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Photographer()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int PhotographerID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Contact { get; set; }
        public string Model_Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
