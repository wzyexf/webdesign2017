//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace design.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Shop_Buyer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Shop_Buyer()
        {
            this.T_Shop_Basket = new HashSet<T_Shop_Basket>();
            this.T_Shop_Order = new HashSet<T_Shop_Order>();
        }
    
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string PWD { get; set; }
        public Nullable<int> Sex { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public Nullable<int> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Shop_Basket> T_Shop_Basket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Shop_Order> T_Shop_Order { get; set; }
    }
}
