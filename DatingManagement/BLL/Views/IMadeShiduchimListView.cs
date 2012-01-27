using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingManagement
{
    public interface IMadeShiduchimListView : IBaseView
    { 

        void LoadGridLayout(string p);

        void SetPermission();

        void RefreshData();

        void SetFocusToNewRow();

        void disableSave();

        void enableSave();

        void LoadDetails();


        void SetDataSource(List<DAL.MadeShiduchim> MadeShiduchimList, bool p);

        void LoadNewData(DAL.MadeShiduchim selectedDetail);
    }
}
