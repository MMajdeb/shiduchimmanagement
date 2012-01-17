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

    public class FamilyListPresenter : BasePresenter
    {
        private IFamilyListView view;
        private IFamilyDetailsView detailsView;
        private Family selectedDetail;
        IGirlDetailsView detailsGirlView;
        IBoyDetailsView detailsBoyView;

        public List<Family> FamilyList = new List<Family>();

        public FamilyListPresenter(IFamilyListView _view, IFamilyDetailsView _detailsView)
            : base(_view)
        {
            if (_view != null)
                view = _view;

            detailsView = _detailsView;
            this.FamilyList = new List<Family>();
        }

        public FamilyListPresenter(IFamilyDetailsView _detailsView)
            : base(_detailsView)
        {
            detailsView = _detailsView;
        }

        public void HandleLoadForm()
        {
            this.Dataclass = new ShiduchimDBDataContext(DataLayer.ConnectionString);
            this.FamilyList = null;
            this.FamilyList = this.Dataclass.Families.ToList();

            view.SetDataSource(FamilyList, false);

            view.SetPermission();

            view.LoadDetails();

        }

        public void Add()
        {
            if (IsUnsavedDataExists())
            {
                if (view != null)
                    view.DisplayMessage("Save first the new family",
                                    Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }

            AddNew();
            view.SetDataSource(FamilyList, true);

        }

        private void AddNew()
        {
            Family cs = new Family();
            cs.FatherName = string.Empty;
            cs.LastName = string.Empty;

            this.FamilyList.Add(cs);
            this.Dataclass.Families.InsertOnSubmit(cs);
            selectedDetail = cs;
        }

        public void Remove(Family ServiceEntry)
        {
            try
            {
                Dataclass.Families.DeleteOnSubmit(ServiceEntry);
                Dataclass.SubmitChanges();
                this.FamilyList.Remove(ServiceEntry);
                RefreshForm();
            }
            catch (Exception ex)
            {
                if (view != null)
                    view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Family"),
                        Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }



        private bool IsUnsavedDataExists()
        {
            return FamilyList.Where(c => c.FathersID == 0).Count() > 0;
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
                        List<Family> details = Dataclass.Families.Where(F => F.FathersID == selectedDetail.FathersID).ToList();
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


        internal void LoadDetails(int FathersID)
        {
            List<Family> details = Dataclass.Families.Where(F => F.FathersID == FathersID).ToList();
            detailsView.ShowPanel();
            selectedDetail = details.First();
            detailsView.LoadDetails(selectedDetail);
            detailsView.LoadBoys(selectedDetail.Boys);
            detailsView.LoadGirls(selectedDetail.Girls);
            detailsView.LoadMechitunem(selectedDetail.Mechitunems);
        }

        private void RefreDetailsForm()
        {
            LoadDetails(selectedDetail);
        }

        public override void RefreshForm()
        {
            view.ResetChange();

        }

        public void RemoveNewAdded()
        {
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(Family));
            if (q.Count() > 0)
            {
                Family deletedObject = (Family)q.First();
                Dataclass.Girls.DeleteAllOnSubmit(deletedObject.Girls);
                Dataclass.Boys.DeleteAllOnSubmit(deletedObject.Boys);
                Dataclass.Mechitunems.DeleteAllOnSubmit(deletedObject.Mechitunems);

                Dataclass.Families.DeleteOnSubmit(deletedObject);
                FamilyList.Remove(deletedObject);
            }
        }

        public void LoadDetails(Family accont)
        {
            selectedDetail = accont;
            if (detailsView == null)
                view.LoadDetails();
            else
            {
                detailsView.LoadDetails(selectedDetail);
                detailsView.LoadBoys(selectedDetail.Boys);
                detailsView.LoadGirls(selectedDetail.Girls);
                detailsView.LoadMechitunem(selectedDetail.Mechitunems);

            }
        }

        public void LoadDetailsView(IFamilyDetailsView _detailsView)
        {
            detailsView = _detailsView;

            detailsView.LoadFormLayout();
            detailsView.SetPermissions();
            detailsView.LoadRegions(Dataclass.Regions.Select(R => R.Region1).Distinct().ToList());
            detailsView.LoadCountries(Dataclass.Countries.Select(R => R.Country1).Distinct().ToList());
            detailsView.LoadHamedresh(Dataclass.BaisHamedreshes.Select(R => R.BaisHamedresh1).Distinct().ToList());
            detailsView.LoadHeight(Dataclass.Heights.Select(R => R.Height1).Distinct().ToList());
            detailsView.LoadYeshiva(Dataclass.Yeshivas.Select(R => R.Yeshiva1).Distinct().ToList());
            detailsView.LoadBaisHamedresh(Dataclass.BaisHamedreshes.Select(R => R.BaisHamedresh1).Distinct().ToList());
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

            if (selectedDetail.FatherName == null)
                errorMsg += "Please add the father name" + Environment.NewLine + Environment.NewLine;

            if (selectedDetail.LastName == null)
            {
                errorMsg += "Please add the father Last name" + Environment.NewLine + Environment.NewLine;
            }
            if (selectedDetail.Address == null)
            {
                errorMsg += "Please add the Address" + Environment.NewLine + Environment.NewLine;
            }


            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    detailsView.DisplayMessage("-----------Can not save this Family-----------" + Environment.NewLine + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }


        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "Family"), Definitions.MESSAGEBOXTITLE.WARNING.ToString()))
            {
                SaveForm(true);
            }
            else
            {
                RemoveNewAdded();
            }
        }



        internal void ModifyBaisHamedresh(bool addtoBaisHamedresh, string BaisHamedresh)
        {

            if (addtoBaisHamedresh)
                selectedDetail.BaisHamedresh += ", " + BaisHamedresh;
            else
                selectedDetail.BaisHamedresh = BaisHamedresh;

            detailsView.LoadDetails(selectedDetail);
        }

        internal void ModifyCountry(bool addtoCountry, string Country)
        {
            if (addtoCountry)
                selectedDetail.Country += ", " + Country;
            else
                selectedDetail.Country = Country;

            detailsView.LoadDetails(selectedDetail);
        }

        internal void LoadGirlsDetailsView(IGirlDetailsView _detailsGirlView)
        {
            detailsGirlView = _detailsGirlView;
            _detailsGirlView.LoadRegions(Dataclass.Regions.Select(R => R.Region1).Distinct().ToList());
            _detailsGirlView.LoadCountries(Dataclass.Countries.Select(R => R.Country1).Distinct().ToList());
            _detailsGirlView.LoadBaisHamedresh(Dataclass.BaisHamedreshes.Select(R => R.BaisHamedresh1).Distinct().ToList());
            _detailsGirlView.LoadYeshiva(Dataclass.Yeshivas.Select(R => R.Yeshiva1).Distinct().ToList());

            _detailsGirlView.LoadHeight(Dataclass.Heights.Select(R => R.Height1).Distinct().ToList());
            _detailsGirlView.LoadSchools(Dataclass.Schools.Select(R => R.School1).Distinct().ToList());
            _detailsGirlView.LoadSeminary(Dataclass.Seminarys.Select(R => R.Seminary1).Distinct().ToList());
            _detailsGirlView.LoadCamps(Dataclass.Camps.Select(R => R.Camp1).Distinct().ToList());

        }

        internal void AddGirl(Family selectedFamily)
        {
            Girl cs = new Girl();
            cs.GirlsName = string.Empty;

            selectedFamily.Girls.Add(cs);
            selectedDetail = selectedFamily;

            detailsGirlView.LoadDetails(cs, selectedFamily);
        }
    }
}
