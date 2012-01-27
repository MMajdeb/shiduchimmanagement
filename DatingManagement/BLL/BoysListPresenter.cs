using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using DevExpress.XtraEditors;
using DatingManagement.DAL;


namespace DatingManagement
{

    public class BoysListPresenter : BasePresenter
    {
        private IBoyListView view;
        private IBoyDetailsView detailsView;
        private Boy selectedDetail;
        Family _selectedFamily;

        public List<Boy> BoyList = new List<Boy>();

        public BoysListPresenter(IBoyListView _view, IBoyDetailsView _detailsView)
            : base(_view)
        {
            view = _view;
            detailsView = _detailsView;
            this.BoyList = new List<Boy>();
        }

        public BoysListPresenter(IBoyDetailsView _detailsView)
            : base(_detailsView)
        {
            detailsView = _detailsView;
        }

        public void HandleLoadForm()
        {
            this.BoyList = this.Dataclass.Boys.ToList();

            view.SetDataSource(BoyList, false);

            view.SetPermission();

            view.LoadDetails();

        }

        public void Add(Family Family)
        {
            if (IsUnsavedDataExists())
            {
                if (view != null)
                    view.DisplayMessage("Save first the new Boy",
                                    Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }
            Boy cs = AddNewBoy();
            cs.FathersID = Family.FathersID;
            this.Dataclass.Boys.InsertOnSubmit(cs);
            this.BoyList.Add(cs);

            _selectedFamily = Family;

            selectedDetail = cs;
            detailsView.LoadDetails(selectedDetail, _selectedFamily);
        }

        private Boy AddNewBoy()
        {
            Boy cs = new Boy();
            cs.BoysName = string.Empty;
            return cs;
        }

        public void Add()
        {
            if (IsUnsavedDataExists())
            {
                if (view != null)
                    view.DisplayMessage("Save first the new Boy",
                                    Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }

            AddNew();
            detailsView.LoadDetails(selectedDetail, _selectedFamily);
        }

        private void AddNew()
        {
            Boy cs = new Boy();
            cs.BoysName = string.Empty;
            this.BoyList.Add(cs);
            //this.Dataclass.Boys.InsertOnSubmit(cs);

            Family newFamily = new Family();
            newFamily.MotherName = string.Empty;
            newFamily.FatherName = string.Empty;
            newFamily.Boys.Add(cs);
            _selectedFamily = newFamily;
            this.Dataclass.Families.InsertOnSubmit(newFamily);
            selectedDetail = cs;
        }

        public void Remove(Boy boy)
        {
            try
            {
                Dataclass.Boys.DeleteOnSubmit(boy);
                Dataclass.SubmitChanges();
                this.BoyList.Remove(boy);
                RefreshForm();
            }
            catch (Exception ex)
            {
                if (view != null)
                    view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Boy"),
                        Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }



        private bool IsUnsavedDataExists()
        {
            return BoyList.Where(c => c.BoysID == 0).Count() > 0;
        }

        public bool SaveForm(bool refreshDetailsForms)
        {
            try
            {
                if (GoodToCalculate(true))
                {
                    this.Dataclass.SubmitChanges();
                    if (view != null)
                        view.DisplayMessage(Definitions.Message.SAVEDSUCCESSFULLYMSG, Definitions.MESSAGEBOXTITLE.SUCCESS);

                    RefreshForm();
                    if (refreshDetailsForms)
                    {
                        List<Boy> details = Dataclass.Boys.Where(F => F.BoysID == selectedDetail.BoysID).ToList();
                        detailsView.LoadDetails(details.First());

                    }
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                CLogger.WriteLog(CLogger.ELogLevel.ERROR, ex);
                if (view != null)
                    view.DisplayMessage(ex.Message + ex.StackTrace, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        internal void LoadDetails(int BoyID)
        {
            List<Boy> details = Dataclass.Boys.Where(F => F.BoysID == BoyID).ToList();

            selectedDetail = details.First();
            detailsView.LoadDetails(selectedDetail);
            detailsView.ShowPanel();
        }

        private void RefreDetailsForm()
        {
            LoadDetails(selectedDetail);
        }

        public override void RefreshForm()
        {
            if (view != null)
                view.ResetChange();

        }

        public void RemoveNewAdded()
        {
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(Boy));
            if (q.Count() > 0)
            {
                Boy deletedObject = (Boy)q.First();

                Dataclass.Boys.DeleteOnSubmit(deletedObject);

                BoyList.Remove(deletedObject);
            }
        }

        public void LoadDetails(Boy accont)
        {
            selectedDetail = accont;
            if (detailsView == null)
                view.LoadDetails();
            else
            {
                detailsView.LoadDetails(selectedDetail);

            }
        }

        public void LoadDetailsView(IBoyDetailsView _detailsView)
        {
            detailsView = _detailsView;

            detailsView.LoadFormLayout();
            detailsView.SetPermissions();
            detailsView.FillFamilyList("Name", "FathersID", Dataclass.Families.ToList());

            detailsView.LoadRegions(Dataclass.Regions.Select(R => R.Region1).Distinct().ToList());
            detailsView.LoadCountries(Dataclass.Countries.Select(R => R.Country1).Distinct().ToList());
            detailsView.LoadHamedresh(Dataclass.BaisHamedreshes.Select(R => R.BaisHamedresh1).Distinct().ToList());
            detailsView.LoadHeight(Dataclass.Heights.Select(R => R.Height1).Distinct().ToList());
            detailsView.LoadBaisHamedresh(Dataclass.BaisHamedreshes.Select(R => R.BaisHamedresh1).Distinct().ToList());
            detailsView.LoadYeshiva(Dataclass.Yeshivas.Select(R => R.Yeshiva1).Distinct().ToList());

            // detailsView.LoadBaisHamedresh(Dataclass.BaisHamedreshes.Select(R => R.BaisHamedresh1).Distinct().ToList());
        }

        public void LoadPopupDetailsView(IBoyDetailsView _detailsView)
        {
            detailsView = _detailsView;

            detailsView.LoadFormLayout();
            detailsView.SetPermissions();

            detailsView.LoadRegions(Dataclass.Regions.Select(R => R.Region1).Distinct().ToList());
            detailsView.LoadCountries(Dataclass.Countries.Select(R => R.Country1).Distinct().ToList());
            detailsView.LoadHeight(Dataclass.Heights.Select(R => R.Height1).Distinct().ToList());
            detailsView.LoadYeshiva(Dataclass.Yeshivas.Select(R => R.Yeshiva1).Distinct().ToList());
            detailsView.LoadBaisHamedresh(Dataclass.BaisHamedreshes.Select(R => R.BaisHamedresh1).Distinct().ToList());
            detailsView.LoadYeshiva(Dataclass.Yeshivas.Select(R => R.Yeshiva1).Distinct().ToList());

            // detailsView.LoadBaisHamedresh(Dataclass.BaisHamedreshes.Select(R => R.BaisHamedresh1).Distinct().ToList());
        }

        private void RefreshDetailsForm()
        {
            detailsView.LoadDetails(selectedDetail);
        }

        public void LoadNewDetailsView()
        {
            if (detailsView != null)
            {
                AddNew();
                detailsView.LoadDetails(selectedDetail);
            }
        }

        private bool GoodToCalculate(bool showMessage)
        {
            string errorMsg = "";

            if (selectedDetail.BoysName == null)
                errorMsg += "Please add the Boys name" + Environment.NewLine + Environment.NewLine;

            if (selectedDetail.BirthDate == null)
            {
                errorMsg += "Please add the Birth Date" + Environment.NewLine + Environment.NewLine;
            }



            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    detailsView.DisplayMessage("-----------Can not save this Boy-----------" + Environment.NewLine + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }


        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "Boy"), Definitions.MESSAGEBOXTITLE.WARNING.ToString()))
            {
                SaveForm(true);
            }
            else
            {
                RemoveNewAdded();
            }
        }

        internal void UpdateAge(DateTime dateTime)
        {
            int age = DateTime.Now.Year - dateTime.Year;
            if (dateTime > DateTime.Now.AddYears(-age))
                age--;

            selectedDetail.Age = age;
            selectedDetail.BirthDate = dateTime;
            detailsView.LoadDetails(selectedDetail);
        }

        internal void ModifyYeshiva(bool addtoYeshiva, string Yeshiva)
        {
            if (addtoYeshiva)
                selectedDetail.Yeshiva += ", " + Yeshiva;
            else
                selectedDetail.Yeshiva = Yeshiva;

            detailsView.LoadDetails(selectedDetail, _selectedFamily);
        }

        internal void LoadFamily(int p)
        {
            selectedDetail.Family = Dataclass.Families.Where(F => F.FathersID == p).First();
            selectedDetail.FathersID = p;
            detailsView.LoadDetails(selectedDetail);
        }

        internal void LoadFamilyDetails(int p)
        {
            selectedDetail.Family = Dataclass.Families.Where(F => F.FathersID == p).First();
            selectedDetail.FathersID = p;
            _selectedFamily = Dataclass.Families.Where(F => F.FathersID == p).First();

            detailsView.LoadDetails(selectedDetail, _selectedFamily);
        }

        internal void LoadPopupDetailsForm(Boy detail)
        {
            selectedDetail = detail;
            _selectedFamily = Dataclass.Families.Where(F => F.FathersID == detail.FathersID).First();

            detailsView.LoadDetails(selectedDetail, _selectedFamily);
        }


        internal void ModifyBaisHamedresh(bool addtoBaisHamedresh, string BaisHamedresh)
        {

            if (addtoBaisHamedresh)
                _selectedFamily.BaisHamedresh += ", " + BaisHamedresh;
            else
                _selectedFamily.BaisHamedresh = BaisHamedresh;

            detailsView.LoadDetails(selectedDetail);
        }

        internal void ModifyCountry(bool addtoCountry, string Country)
        {
            if (addtoCountry)
                _selectedFamily.Country += ", " + Country;
            else
                _selectedFamily.Country = Country;

            detailsView.LoadDetails(selectedDetail);
        }
    }
}
