﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{       
    public interface IFinancialYearsView
    {
        SortType SortDirection{get;set;}
        SortFieldType SortField { get; set; }
        void OrderFinancialYearbyFieldAndDirection(List<FinancialYears> financialyears);
    }
}
