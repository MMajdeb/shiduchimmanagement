using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingManagement
{
    public interface ISeminarysView : IBaseView
    {


        void RefreshData();

        void SetFocusToNewRow();

        void disableSave();

        void enableSave();

        void SetDataSource(List<DAL.Seminary> SeminaryList, bool p);
    }
}
