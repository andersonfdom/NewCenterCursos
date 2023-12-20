using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpESubmissionsValue
    {
        public ulong Id { get; set; }
        public ulong SubmissionId { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
    }
}
