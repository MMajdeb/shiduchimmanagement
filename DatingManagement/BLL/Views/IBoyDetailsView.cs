using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DatingManagement
{

    public interface IBoyDetailsView : IBaseDetailsView
    {
        
        void LoadFormLayout();



        void LoadDetails(DAL.Boy boy);

        void LoadHeight(List<string> list);

        void LoadYeshiva(List<string> list);

        void FillFamilyList(string p, string p_2, List<DAL.Family> list);

        void ShowPanel();
    }
}
