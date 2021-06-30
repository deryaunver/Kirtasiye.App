//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Kirtasiye.Shared.Entities.Abstract;

namespace Kirtasiye.Entities.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Stock { get; set; }
        public string Picture { get; set; }
        public int CategoryId { get; set; }
    
        public virtual Category Category { get; set; }
    }
}