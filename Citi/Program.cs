using System;
using System.Collections;
using System.Collections.Generic;

namespace Citi
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataSource datasource = new CSVDataSource(@"C:\input.csv");
            StockExchange se = new StockExchange(datasource);
            List<IEntity> entities = se.GetEntities;
        }
    }
}
