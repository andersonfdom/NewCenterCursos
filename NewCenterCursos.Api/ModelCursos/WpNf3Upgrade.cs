using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpNf3Upgrade
    {
        public int Id { get; set; }
        public string? Cache { get; set; }
        public int Stage { get; set; }
        public ulong? Maintenance { get; set; }
    }
}
