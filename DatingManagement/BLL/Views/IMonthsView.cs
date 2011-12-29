using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingManagement
{
    public interface IMonthsView : IBaseView 
    { 

       
        void RefreshData();

        void SetFocusToNewRow();

        void disableSave();

        void enableSave();

        void SetDataSource(List<DAL.Month> MonthList, bool p);
    }
}
