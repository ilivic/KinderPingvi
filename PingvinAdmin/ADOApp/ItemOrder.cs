//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PingvinAdmin.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemOrder
    {
        public int id_ItemOrder { get; set; }
        public int Item_id { get; set; }
        public int Order_id { get; set; }
        public System.DateTime Date { get; set; }
        public int TypeItems_id { get; set; }
    
        public virtual Items Items { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual TypeItems TypeItems { get; set; }
    }
}
