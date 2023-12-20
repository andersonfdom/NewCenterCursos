using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpTermRelationship
    {
        public ulong ObjectId { get; set; }
        public ulong TermTaxonomyId { get; set; }
        public int TermOrder { get; set; }
    }
}
