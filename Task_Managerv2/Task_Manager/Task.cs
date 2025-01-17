//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task_Manager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            this.Subtask = new HashSet<Subtask>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Specification { get; set; }
        public System.DateTime DateOfStart { get; set; }
        public Nullable<System.DateTime> DateOfEnd { get; set; }
        public int IdStatus { get; set; }
        public int IdTeam { get; set; }
    
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subtask> Subtask { get; set; }
        public virtual Teams Teams { get; set; }
    }
}
