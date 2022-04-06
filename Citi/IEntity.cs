using System;
using System.Collections.Generic;
using System.Text;

namespace Citi
{
    interface IEntity
    {
        long Amout { get; set; }
        string Stock { get; set; }
        string Period { get; set; }
    }
}
