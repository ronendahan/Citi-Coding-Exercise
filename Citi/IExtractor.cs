using System;
using System.Collections.Generic;
using System.Text;

namespace Citi
{
    interface IExtractor
    {
        IEntity Extract(string source);
    }
}
