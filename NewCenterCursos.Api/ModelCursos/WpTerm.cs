﻿using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpTerm
    {
        public ulong TermId { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public long TermGroup { get; set; }
    }
}
