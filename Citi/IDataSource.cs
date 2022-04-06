using System;
using System.Collections.Generic;
using System.Text;

namespace Citi
{
    interface IDataSource
    {
        List<IEntity> GetData();
    }
}
