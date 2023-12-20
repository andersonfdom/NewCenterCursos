using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpLayerslider
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public int Author { get; set; }
        public string? Name { get; set; }
        public string? Slug { get; set; }
        public string Data { get; set; } = null!;
        public int DateC { get; set; }
        public int DateM { get; set; }
        public int ScheduleStart { get; set; }
        public int ScheduleEnd { get; set; }
        public bool FlagHidden { get; set; }
        public bool FlagDeleted { get; set; }
        public bool FlagPopup { get; set; }
        public bool FlagGroup { get; set; }
    }
}
