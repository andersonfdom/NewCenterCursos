﻿using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpCommentmetum
    {
        public ulong MetaId { get; set; }
        public ulong CommentId { get; set; }
        public string? MetaKey { get; set; }
        public string? MetaValue { get; set; }
    }
}
