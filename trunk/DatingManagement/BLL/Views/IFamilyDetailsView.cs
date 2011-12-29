using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DatingManagement
{

    public interface IFamilyDetailsView : IBaseDetailsView
    {
        
        void LoadFormLayout();

        void LoadDetails(DAL.Family detail);
                 
        void LoadMechitunem(System.Data.Linq.EntitySet<DAL.Mechitunem> entitySet);

        void LoadGirls(System.Data.Linq.EntitySet<DAL.Girl> entitySet);

        void LoadBoys(System.Data.Linq.EntitySet<DAL.Boy> entitySet);

        void LoadRegions(List<string> list);

        void LoadCountries(List<string> list);

        void LoadHamedresh(List<string> list);

        void LoadHeight(List<string> list);

        void LoadYeshiva(List<string> list);

        void LoadBaisHamedresh(List<string> list);

        void ShowPanel();
    }
}
