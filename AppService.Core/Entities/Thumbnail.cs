using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public partial class Thumbnail
    {
        public int Id { get; set; }
        public byte[] Data { get; set; }
        public string Fname { get; set; }
    }
}
