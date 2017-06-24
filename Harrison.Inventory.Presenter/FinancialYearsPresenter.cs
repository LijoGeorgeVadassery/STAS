﻿using System;
using System.Collections.Generic;
using System.Text;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Service;

namespace Harrison.Inventory.Presenter
{
    public class FinancialYearsPresenter : IFinancialYearsPresenter
    {
        private IFinancialYearsView _iFinancialYearsView;
        private IFinancialYearsService _iFinacialYearsService;

        public FinancialYearsPresenter(IFinancialYearsView iFinancialYearsView, IFinancialYearsService iFinancialYearsService)
        {
            _iFinancialYearsView = iFinancialYearsView;
            _iFinacialYearsService = iFinancialYearsService;
            
        }

        public void init()
        {
            _iFinancialYearsView.OrderFinancialYearbyFieldAndDirection(_iFinacialYearsService.GetAllFinancialYears(SortType.Ascending,SortFieldType.Id));
        }
        public void FinancialYearsSort(SortType sortType ,SortFieldType sortFieldType)
    {
        _iFinancialYearsView.OrderFinancialYearbyFieldAndDirection(_iFinacialYearsService.GetAllFinancialYears(sortType, sortFieldType));
    }
    }
}
