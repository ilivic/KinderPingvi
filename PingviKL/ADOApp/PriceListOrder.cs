//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PingviKL.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class PriceListOrder
    {
        public int id_PriceOrder { get; set; }
        public int Order_id { get; set; }
        public int Price_id { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual PriceList PriceList { get; set; }
    }
}
