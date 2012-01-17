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

    public class GirlsListPresenter : BasePresenter
    {
        private IGirlListView view;
        private IGirlDetailsView detailsView;
        private Girl selectedDetail;
        Family _selectedFamily;

        public List<Girl> GirlList = new List<Girl>();

        public GirlsListPresenter(IGirlListView _view, IGirlDetailsView _detailsView)
            : base(_view)
        {
            view = _view;
            detailsView = _detailsView;
            this.GirlList = new List<Girl>();
        }



        public GirlsListPresenter(IGirlDetailsView _detailsView)
            : base(_detailsView)
        {
            detailsView = _detailsView;
        }

        public void HandleLoadForm()
        {
            this.GirlList = this.Dataclass.Girls.ToList();

            view.SetDataSource(GirlList, false);


            view.SetPermission();

            view.LoadDetails();

        }

        public void Add(Family Family)
        {
            if (IsUnsavedDataExists())
            {
                if (view != null)
                    view.DisplayMessage("Save first the new Girl",
                                    Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }
            Girl cs = AddNewGirl();
            cs.FathersID = Family.FathersID;
            this.Dataclass.Girls.InsertOnSubmit(cs);
            this.GirlList.Add(cs);

            _selectedFamily = Family;

            selectedDetail = cs;
            detailsView.LoadDetails(selectedDetail, _selectedFamily);
        }

        public void Add()
        {
            if (IsUnsavedDataExists())
            {
                if (view != null)
                    view.DisplayMessage("Save first the new Girl",
                                    Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }
            Girl cs = AddNewGirl();

            this.GirlList.Add(cs);
            Family newFamily = new Family();
            newFamily.MotherName = string.Empty;
            newFamily.FatherName = string.Empty;
            newFamily.Girls.Add(cs);
            _selectedFamily = newFamily;
            this.Dataclass.Families.InsertOnSubmit(newFamily);
            selectedDetail = cs;
            detailsView.LoadDetails(selectedDetail, _selectedFamily);
        }

        private Girl AddNewGirl()
        {
            Girl cs = new Girl();
            cs.GirlsName = string.Empty;
            return cs;

        }

        public void Remove(Girl Girl)
        {
            try
            {
                Dataclass.Girls.DeleteOnSubmit(Girl);
                Dataclass.SubmitChanges();
                this.GirlList.Remove(Girl);
                RefreshForm();
            }
            catch (Exception ex)
            {
                if (view != null)
                    view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Girl"),
                        Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }



        private bool IsUnsavedDataExists()
        {
            return GirlList.Where(c => c.GirlsID == 0).Count() > 0;
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
                        List<Girl> details = Dataclass.Girls.Where(F => F.GirlsID == selectedDetail.GirlsID).ToList();
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
        internal void LoadDetails(int GirlID)
        {
            List<Girl> details = Dataclass.Girls.Where(F => F.GirlsID == GirlID).ToList();

            selectedDetail = details.First();
            detailsView.LoadDetails(selectedDetail);
            detailsView.ShowPanel();
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
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(Girl));
            if (q.Count() > 0)
            {
                Girl deletedObject = (Girl)q.First();

                Dataclass.Girls.DeleteOnSubmit(deletedObject);

                GirlList.Remove(deletedObject);
            }
        }

        public void LoadDetails(Girl accont)
        {
            selectedDetail = accont;
            if (detailsView == null)
                view.LoadDetails();
            else
            {
                detailsView.LoadDetails(selectedDetail);

            }
        }

        public void LoadDetailsView(IGirlDetailsView _detailsView)
        {
            detailsView = _detailsView;

            detailsView.LoadFormLayout();
            detailsView.SetPermissions();
            detailsView.FillFamilyList("Name", "FathersID", Dataclass.Families.ToList());

            detailsView.LoadRegions(Dataclass.Regions.Select(R => R.Region1).Distinct().ToList());
            detailsView.LoadCountries(Dataclass.Countries.Select(R => R.Country1).Distinct().ToList());
            detailsView.LoadBaisHamedresh(Dataclass.BaisHamedreshes.Select(R => R.BaisHamedresh1).Distinct().ToList());
            detailsView.LoadYeshiva(Dataclass.Yeshivas.Select(R => R.Yeshiva1).Distinct().ToList());

            detailsView.LoadHeight(Dataclass.Heights.Select(R => R.Height1).Distinct().ToList());
            detailsView.LoadSchools(Dataclass.Schools.Select(R => R.School1).Distinct().ToList());
            detailsView.LoadSeminary(Dataclass.Seminarys.Select(R => R.Seminary1).Distinct().ToList());
            detailsView.LoadCamps(Dataclass.Camps.Select(R => R.Camp1).Distinct().ToList());

        }

        public void LoadPopupDetailsView(IGirlDetailsView _detailsView)
        {
            detailsView = _detailsView;

            detailsView.LoadFormLayout();
            detailsView.SetPermissions();

            detailsView.LoadRegions(Dataclass.Regions.Select(R => R.Region1).Distinct().ToList());
            detailsView.LoadCountries(Dataclass.Countries.Select(R => R.Country1).Distinct().ToList());
            detailsView.LoadHeight(Dataclass.Heights.Select(R => R.Height1).Distinct().ToList());
            detailsView.LoadYeshiva(Dataclass.Yeshivas.Select(R => R.Yeshiva1).Distinct().ToList());
            detailsView.LoadBaisHamedresh(Dataclass.BaisHamedreshes.Select(R => R.BaisHamedresh1).Distinct().ToList());

            detailsView.LoadHeight(Dataclass.Heights.Select(R => R.Height1).Distinct().ToList());
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
                Add();
                detailsView.LoadDetails(selectedDetail);
            }
        }

        private bool GoodToCalculate(bool showMessage)
        {
            string errorMsg = "";

            if (selectedDetail.GirlsName == null)
                errorMsg += "Please add the Girls name" + Environment.NewLine + Environment.NewLine;

            if (selectedDetail.BirthDate == null)
            {
                errorMsg += "Please add the Birth Date" + Environment.NewLine + Environment.NewLine;
            }



            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    detailsView.DisplayMessage("-----------Can not save this Girl-----------" + Environment.NewLine + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }


        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "Girl"), Definitions.MESSAGEBOXTITLE.WARNING.ToString()))
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

        internal void LoadFamily(int p)
        {
            selectedDetail.Family = Dataclass.Families.Where(F => F.FathersID == p).First();
            selectedDetail.FathersID = p;
            detailsView.LoadDetails(selectedDetail);
        }

        internal void ModifyCamp(bool addtoCamp, string Camp)
        {
            if (addtoCamp)
                selectedDetail.Camp += ", " + Camp;
            else
                selectedDetail.Camp = Camp;

            detailsView.LoadDetails(selectedDetail);
        }

        internal void ModifySchool(bool addtoSchool, string School)
        {
            if (addtoSchool)
                selectedDetail.School += ", " + School;
            else
                selectedDetail.School = School;

            detailsView.LoadDetails(selectedDetail);
        }

        internal void ModifySeminary(bool addtoSeminary, string Seminary)
        {
            if (addtoSeminary)
                selectedDetail.Seminary += ", " + Seminary;
            else
                selectedDetail.Seminary = Seminary;

            detailsView.LoadDetails(selectedDetail);
        }



        internal void LoadPopupDetailsForm(Girl detail)
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
