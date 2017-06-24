using System;
using System.Collections.Generic;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class FinancialYearsDAL:IFinancialYearsDAL
    {
        public List<FinancialYears> GetAllFinancialYears()
        {
            return new List<FinancialYears>
            {
                new FinancialYears(1,"2015-2016"),
                new FinancialYears(2,"2016-2017"),
                new FinancialYears(3,"2017-2018"),
                new FinancialYears(4,"2018-2019"),
                new FinancialYears(10,"2019-2020")
            };
        }
    }
}
