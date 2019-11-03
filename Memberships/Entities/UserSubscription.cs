using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    public class UserSubscription
    {
        [required]
        [Key, Column(Order = 1)]
        public int SubscriptionId { get; set; }
        [required]
        [Key, Column(Order = 2)]
        [MaxLength(128)]
        public string UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }


    }
}