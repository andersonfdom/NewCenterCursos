using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpESubmissionsActionsLog
    {
        public ulong Id { get; set; }
        public ulong SubmissionId { get; set; }
        public string ActionName { get; set; } = null!;
        public string? ActionLabel { get; set; }
        public string Status { get; set; } = null!;
        public string? Log { get; set; }
        public DateTime CreatedAtGmt { get; set; }
        public DateTime UpdatedAtGmt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
