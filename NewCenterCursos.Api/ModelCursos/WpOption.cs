using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpOption
    {
        public ulong OptionId { get; set; }
        public string OptionName { get; set; } = null!;
        public string OptionValue { get; set; } = null!;
        public string Autoload { get; set; } = null!;
    }
}
