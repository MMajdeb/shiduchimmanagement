using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingManagement
{
    public interface IBoyListView : IBaseView
    { 

        void LoadGridLayout(string p);

        void SetPermission();

        void RefreshData();

        void SetFocusToNewRow();

        void disableSave();

        void enableSave();

        void LoadDetails();
         
        void SetDataSource(List<DAL.Boy> BoyList, bool p);

         
    }
}
