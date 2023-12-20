using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpNf3Field
    {
        public int Id { get; set; }
        public string? Label { get; set; }
        public string? Key { get; set; }
        public string? Type { get; set; }
        public int ParentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? FieldLabel { get; set; }
        public string? FieldKey { get; set; }
        public int? Order { get; set; }
        public ulong? Required { get; set; }
        public string? DefaultValue { get; set; }
        public string? LabelPos { get; set; }
        public ulong? PersonallyIdentifiable { get; set; }
    }
}
