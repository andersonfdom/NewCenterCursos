using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpDuplicatorPackage
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string Hash { get; set; } = null!;
        public int Status { get; set; }
        public DateTime Created { get; set; }
        public string Owner { get; set; } = null!;
        public string Package { get; set; } = null!;
    }
}
