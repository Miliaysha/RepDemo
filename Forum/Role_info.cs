//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Forum
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role_info
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Phone { get; set; }
        public int Events_id { get; set; }
        public int Role_id { get; set; }
    
        public virtual Events Events { get; set; }
        public virtual Role Role { get; set; }
    }
}
