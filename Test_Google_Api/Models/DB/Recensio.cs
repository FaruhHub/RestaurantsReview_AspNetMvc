//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_Google_Api.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recensio
    {
        public Recensio()
        {
            this.UserComments = new HashSet<UserComments>();
        }
    
        public int id { get; set; }
        public int restaurantId { get; set; }
        public string description { get; set; }
        public int kitchenMark { get; set; }
        public int interiorMark { get; set; }
        public int serviceMark { get; set; }
        public System.DateTime dateOfCreation { get; set; }
        public string customLabel { get; set; }
    
        public virtual Restaurants Restaurants { get; set; }
        public virtual ICollection<UserComments> UserComments { get; set; }
    }
}