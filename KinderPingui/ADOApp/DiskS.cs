//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinderPingui.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiskS
    {
        public int id_Disk { get; set; }
        public string Title { get; set; }
        public int countOrder { get; set; }
        public int User_id { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
