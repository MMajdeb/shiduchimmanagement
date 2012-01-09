using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DatingManagement
{

    public interface IMadeShiduchimDetailsView : IBaseDetailsView
    {
        
        void LoadFormLayout();


        void LoadDetails(DAL.MadeShiduchim madeShiduchim);

        void FillBoysList(string p, string p_2, List<DAL.Family> list);

        void FillGirlsList(string p, string p_2, List<DAL.Family> list);

        

        void FillMonthsList(string p, string p_2, List<DAL.Month> list);
    }
}
