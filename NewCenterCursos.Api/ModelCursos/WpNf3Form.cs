using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpNf3Form
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Key { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Views { get; set; }
        public int? Subs { get; set; }
        public string? FormTitle { get; set; }
        public string? DefaultLabelPos { get; set; }
        public ulong? ShowTitle { get; set; }
        public ulong? ClearComplete { get; set; }
        public ulong? HideComplete { get; set; }
        public ulong? LoggedIn { get; set; }
        public int? SeqNum { get; set; }
    }
}
