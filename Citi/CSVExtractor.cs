using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace Citi
{
    class CSVExtractor: IExtractor
    {
        public IEntity Extract(string source)
        {
            CSVEntity entity = new CSVEntity();
            entity.Amout = ExtractAmount(source);

            return entity;
        }

        private long ExtractAmount(string source)
        {
            Regex re = new Regex(@"\d+");
            long amount = 0;
            Match amountMatch = re.Match(source);
            if (amountMatch.Success)
            {
                amount = Convert.ToInt64(amountMatch.Value);
                
            }
            return amount;

        }
    }
}
