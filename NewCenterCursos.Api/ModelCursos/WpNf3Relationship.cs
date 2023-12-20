using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpNf3Relationship
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public string ChildType { get; set; } = null!;
        public int ParentId { get; set; }
        public string ParentType { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
