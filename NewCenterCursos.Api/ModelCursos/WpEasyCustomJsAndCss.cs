using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpEasyCustomJsAndCss
    {
        public ulong Id { get; set; }
        public string? Title { get; set; }
        public string? Data { get; set; }
        public string? Type { get; set; }
        public sbyte Active { get; set; }
        public uint Priority { get; set; }
        public string? Options { get; set; }
        public ulong Author { get; set; }
        public DateTime Date { get; set; }
        public DateTime Modified { get; set; }
    }
}
