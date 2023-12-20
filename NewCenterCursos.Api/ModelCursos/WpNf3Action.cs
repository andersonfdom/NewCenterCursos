using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpNf3Action
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Key { get; set; }
        public string? Type { get; set; }
        public bool? Active { get; set; }
        public int ParentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? Label { get; set; }
    }
}
