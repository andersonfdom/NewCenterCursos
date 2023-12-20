using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class WpLitespeedUrlFile
    {
        public long Id { get; set; }
        public long UrlId { get; set; }
        /// <summary>
        /// md5 of final vary
        /// </summary>
        public string Vary { get; set; } = null!;
        /// <summary>
        /// md5 of file content
        /// </summary>
        public string Filename { get; set; } = null!;
        /// <summary>
        /// css=1,js=2,ccss=3,ucss=4
        /// </summary>
        public sbyte Type { get; set; }
        /// <summary>
        /// mobile=1
        /// </summary>
        public sbyte Mobile { get; set; }
        /// <summary>
        /// webp=1
        /// </summary>
        public sbyte Webp { get; set; }
        public int Expired { get; set; }
    }
}
