using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpLayersliderRevision
    {
        public int Id { get; set; }
        public int SliderId { get; set; }
        public int Author { get; set; }
        public string Data { get; set; } = null!;
        public int DateC { get; set; }
    }
}
