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
    
    public partial class MemberSubtask
    {
        public int Id { get; set; }
        public int IdMember { get; set; }
        public int IdSubtask { get; set; }
    
        public virtual Members Members { get; set; }
        public virtual Subtask Subtask { get; set; }
    }
}
