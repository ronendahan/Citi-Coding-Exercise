using System;
using System.Collections.Generic;
using System.Text;

namespace Citi
{
    class CSVEntity : IEntity
    {
        public long Amout { get; set; }
        public string Stock { get; set; }
        public string Period { get; set; }
    }
}
