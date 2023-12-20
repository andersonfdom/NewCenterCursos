using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpESubmission
    {
        public ulong Id { get; set; }
        public string? Type { get; set; }
        public string HashId { get; set; } = null!;
        /// <summary>
        /// Id of main field. to represent the main meta field
        /// </summary>
        public ulong MainMetaId { get; set; }
        public ulong PostId { get; set; }
        public string Referer { get; set; } = null!;
        public string? RefererTitle { get; set; }
        public string ElementId { get; set; } = null!;
        public string FormName { get; set; } = null!;
        public ulong CampaignId { get; set; }
        public ulong? UserId { get; set; }
        public string UserIp { get; set; } = null!;
        public string UserAgent { get; set; } = null!;
        public int? ActionsCount { get; set; }
        public int? ActionsSucceededCount { get; set; }
        public string Status { get; set; } = null!;
        public bool IsRead { get; set; }
        public string? Meta { get; set; }
        public DateTime CreatedAtGmt { get; set; }
        public DateTime UpdatedAtGmt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
