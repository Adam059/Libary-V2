//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookList()
        {
            this.Patrons = new HashSet<Patrons>();
        }
    
        public int LoanID { get; set; }
        public int BookCopyID { get; set; }
        public System.DateTime DateBorrow { get; set; }
        public Nullable<System.DateTime> DateReturn { get; set; }
    
        public virtual Book_Copy Book_Copy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patrons> Patrons { get; set; }
    }
}
