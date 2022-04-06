using System;
using System.Collections.Generic;
using System.Text;

namespace Citi
{
    class StockExchange
    {
        // private readonly Lazy<List<IEntity>> _entities;
        private readonly List<IEntity> _entities;
        public StockExchange(IDataSource datasource)
        {
            // _entities = new Lazy<List<IEntity>>(() => datasource.GetData());
            _entities = datasource.GetData();
        }

        public List<IEntity> GetEntities
        {
            get 
            {
                //return _entities.Value;
                return _entities;
            }
        }
    }
}


