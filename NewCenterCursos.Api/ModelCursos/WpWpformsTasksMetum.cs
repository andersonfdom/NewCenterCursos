using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpWpformsTasksMetum
    {
        public long Id { get; set; }
        public string Action { get; set; } = null!;
        public string Data { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
