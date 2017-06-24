
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
      public class FinancialYears
    {
    #region //public properties
        public int FinancialYearId{get;set;}
        public string FinancialYear { get; set; }   
    #endregion
    #region //Constructors
public FinancialYears(int FinancialYearId,string FinancialYear)
{
    this.FinancialYearId=FinancialYearId;
    this.FinancialYear=FinancialYear;
}    
    #endregion
    }
}
