//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppOreshnikov.Application_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class polzovateli
    {
        public int kod { get; set; }
        public string imya { get; set; }
        public string login { get; set; }
        public string parol { get; set; }
        public int rol { get; set; }
    
        public virtual Roli Roli { get; set; }
    }
}
