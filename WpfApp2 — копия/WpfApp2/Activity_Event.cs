//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity_Event
    {
        public int IDActivityEvent { get; set; }
        public int activityID { get; set; }
        public int eventID { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Event Event { get; set; }
    }
}
