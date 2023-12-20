using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpEEvent
    {
        public ulong Id { get; set; }
        public string? EventData { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
