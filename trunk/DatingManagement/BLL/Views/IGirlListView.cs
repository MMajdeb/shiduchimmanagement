using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingManagement
{
    public interface IGirlListView : IBaseView
    { 

        void LoadGridLayout(string p);

        void SetPermission();

        void RefreshData();

        void SetFocusToNewRow();

        void disableSave();

        void enableSave();

        void LoadDetails();

        void SetDataSource(List<DAL.Girl> GirlList, bool p);
    }
}
