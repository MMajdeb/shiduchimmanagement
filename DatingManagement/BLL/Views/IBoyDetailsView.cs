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

        void LoadRegions(List<string> list);

        void LoadCountries(List<string> list);

        void LoadBaisHamedresh(List<string> list);

        void LoadHamedresh(List<string> list);

        void LoadDetails(DAL.Boy selectedDetail, DAL.Family selectedFamily);
    }
}
