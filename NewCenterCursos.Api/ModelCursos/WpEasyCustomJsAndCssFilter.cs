using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpEasyCustomJsAndCssFilter
    {
        public ulong Id { get; set; }
        public string? Title { get; set; }
        public string? Data { get; set; }
        public ulong Author { get; set; }
        public DateTime Date { get; set; }
        public DateTime Modified { get; set; }
    }
}
