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
    
    public partial class T_Shop_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Shop_Order()
        {
            this.T_Shop_OrderItems = new HashSet<T_Shop_OrderItems>();
        }
    
        public int Id { get; set; }
        public string ConnectorName { get; set; }
        public string ConnectorAddress { get; set; }
        public string ConnectorPhone { get; set; }
        public Nullable<decimal> TotalMoney { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> BuyerId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Shop_OrderItems> T_Shop_OrderItems { get; set; }
        public virtual T_Shop_Buyer T_Shop_Buyer { get; set; }
    }
}