using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpWpformsPaymentMetum
    {
        public long Id { get; set; }
        public long PaymentId { get; set; }
        public string? MetaKey { get; set; }
        public string? MetaValue { get; set; }
    }
}
