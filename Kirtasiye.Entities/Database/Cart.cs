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
    
    public partial class Cart:IEntity
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> CategoryId { get; set; }
    }
}
