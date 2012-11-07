using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Drawing;
using DatingManagement.DAL;


namespace DatingManagement
{
    public class CountryPresenter : BasePresenter
    {
        private ICountrysView view;
        Country selectedDetail;

        List<Country> CountryList = new List<Country>();

        public CountryPresenter(ICountrysView _view)
            : base(_view)
        {
            view = _view;


        }

        public void HandleLoadForm()
        {
            this.CountryList = this.Dataclass.Countries.OrderBy(O=>O.Country1).ToList();
            view.SetDataSource(CountryList, false);

        }


        public void Add()
        {

            //if (IsUnsavedDataExists())
            //{
            //    view.DisplayMessage("Save first the Country", Definitions.MESSAGEBOXTITLE.WARNING);
            //    return;
            //}

            AddNew();
            view.SetDataSource(CountryList, true);
        }

        private void AddNew()
        {
            Country cs = new Country();
            this.CountryList.Add(cs);
            this.Dataclass.Countries.InsertOnSubmit(cs);
            selectedDetail = cs;
        }

        public void Remove(Country Country)
        {
            try
            {
                Dataclass.Countries.DeleteOnSubmit(Country);
                Dataclass.SubmitChanges();
                this.CountryList.Remove(Country);
                RefreshForm();
            }
            catch (Exception ex)
            {
                view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Country"), Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }

        public void CompareName(Country TbTehnicean)
        {
            if (TbTehnicean == null) return;
            if (IsExisting(TbTehnicean))
            {
                view.DisplayMessage(String.Format(Definitions.Message.ALREADYEXISTING, "Country", TbTehnicean.Country1), Definitions.MESSAGEBOXTITLE.WARNING);
                view.disableSave();
                return;
            }

            view.enableSave();
        }

        public bool IsExisting(Country TbTehnicean)
        {
            string NameToCompare = TbTehnicean.Country1.Trim();

            //Looks for the deleted object in the Dataclass that match the name
            var deleted = Dataclass.GetChangeSet().Deletes.Where(C => C.GetType() == typeof(Country)).ToList();
            foreach (Country cst in deleted)
            {
                if (cst.Country1 == NameToCompare)
                {
                    return true;
                }
            }
            //Search for the existing category in the the database
            var acc = (from C in Dataclass.Countries
                       where C.Country1 == NameToCompare
                       && C.Country_Id != TbTehnicean.Country_Id
                       select C.Country_Id);


            string Name = NameToCompare;

            if (acc != null && acc.Count() > 0)
            {
                return true;

            }
            return false;
        }

        private bool IsUnsavedDataExists()
        {
            return CountryList.Where(c => c.Country_Id == 0).Count() > 0;
        }

        public bool SaveForm(bool refreshDetailsForms)
        {
            try
            {
                this.Dataclass.SubmitChanges();

                RefreshForm();

                return true;
            }
            catch (Exception ex)
            {
                CLogger.WriteLog(CLogger.ELogLevel.ERROR, ex);
                view.DisplayMessage(ex.Message + ex.StackTrace, Definitions.MESSAGEBOXTITLE.ERROR); return false;
            }
        }

        public override void RefreshForm()
        {
            view.ResetChange();
            view.SetDataSource(CountryList, false);
        }

        public void RemoveNewAdded()
        {
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(Country));
            if (q.Count() > 0)
            {
                Country deletedObject = (Country)q.First();
                Dataclass.Countries.DeleteOnSubmit(deletedObject);
                CountryList.Remove(deletedObject);
            }
        }


        private bool GoodToCalculate(bool showMessage)
        {
            string errorMsg = "";

            if (selectedDetail.Country1 == null)
                errorMsg += "Enter a name for the Country " + Environment.NewLine;


            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    view.DisplayMessage("Can not save the Country" + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }

        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "Country"),
                                        Definitions.MESSAGEBOXTITLE.WARNING.ToString()))
            {
                SaveForm(true);
            }
            else
            {
                RemoveNewAdded();
            }
        }

    }
}
