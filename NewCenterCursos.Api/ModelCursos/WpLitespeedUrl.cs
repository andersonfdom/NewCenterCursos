using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpLitespeedUrl
    {
        public long Id { get; set; }
        public string Url { get; set; } = null!;
        public string CacheTags { get; set; } = null!;
    }
}
