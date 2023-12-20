using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpNf3FieldMetum
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Key { get; set; } = null!;
        public string? Value { get; set; }
        public string? MetaKey { get; set; }
        public string? MetaValue { get; set; }
    }
}
