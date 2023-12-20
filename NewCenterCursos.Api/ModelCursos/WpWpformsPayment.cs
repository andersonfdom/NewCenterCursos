using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpWpformsPayment
    {
        public long Id { get; set; }
        public long FormId { get; set; }
        public string Status { get; set; } = null!;
        public decimal SubtotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string Currency { get; set; } = null!;
        public long EntryId { get; set; }
        public string Gateway { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Mode { get; set; } = null!;
        public string TransactionId { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public string SubscriptionId { get; set; } = null!;
        public string SubscriptionStatus { get; set; } = null!;
        public string Title { get; set; } = null!;
        public DateTime DateCreatedGmt { get; set; }
        public DateTime DateUpdatedGmt { get; set; }
        public bool? IsPublished { get; set; }
    }
}
