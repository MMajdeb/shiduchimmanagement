using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DatingManagement
{

    public interface IGirlDetailsView : IBaseDetailsView
    {
        
        void LoadFormLayout();



        void LoadDetails(DAL.Girl girl);

        void FillFamilyList(string p, string p_2, List<DAL.Family> list);

        void LoadHeight(List<string> list);

        void LoadSchools(List<string> list);

        void LoadSeminary(List<string> list);

        void LoadCamps(List<string> list);

        void ShowPanel();

        void LoadRegions(List<string> list);

        void LoadCountries(List<string> list);

        void LoadBaisHamedresh(List<string> list);

        void LoadYeshiva(List<string> list);

        void LoadDetails(DAL.Girl selectedDetail, DAL.Family selectedFamily);
    }
}
