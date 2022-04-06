using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Citi
{
    class CSVDataSource : IDataSource
    {
        private string _filePath;

        public CSVDataSource(string filePath)
        {
            _filePath = filePath;
        }

        public List<IEntity> GetData()
        {
            CSVExtractor extractor = new CSVExtractor();
            List<IEntity> entityList = new List<IEntity>();
            var rows = File.ReadAllLines(_filePath);
            for (int i = 1; i < rows.Length; i++)
            {

               // var delimitedLine = row.Split('\n');
                IEntity entity = extractor.Extract(rows[i]);
                entityList.Add(entity);
            }

            return entityList;
        }
    }
}
