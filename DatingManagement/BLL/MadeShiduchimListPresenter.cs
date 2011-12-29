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

    public class MadeShiduchimsListPresenter : BasePresenter
    {
        private IMadeShiduchimListView view;
        private IMadeShiduchimDetailsView detailsView;
        private MadeShiduchim selectedDetail;


        public List<MadeShiduchim> MadeShiduchimList = new List<MadeShiduchim>();

        public MadeShiduchimsListPresenter(IMadeShiduchimListView _view, IMadeShiduchimDetailsView _detailsView)
            : base(_view)
        {
            view = _view;
            detailsView = _detailsView;
            this.MadeShiduchimList = new List<MadeShiduchim>();
        }

        public void HandleLoadForm()
        {
            this.MadeShiduchimList = this.Dataclass.MadeShiduchims.ToList();

            view.SetDataSource(MadeShiduchimList, false);

            view.SetPermission();

            view.LoadDetails();
            LoadLocalLists();
        }
        private void LoadLocalLists()
        {
            view.FillListInGrid("BoysSide", "Name", "FathersID", Dataclass.Families.ToList());
            view.FillListInGrid("GirlsSide", "Name", "FathersID", Dataclass.Families.ToList());
        }

        public void Add()
        {
            if (IsUnsavedDataExists())
            {
                view.DisplayMessage("Save first the new MadeShiduchim",
                                Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }

            AddNew();
            view.SetDataSource(MadeShiduchimList, true);

        }

        private void AddNew()
        {
            MadeShiduchim cs = new MadeShiduchim();
            cs.Year = DateTime.Now.Year.ToString();


            this.MadeShiduchimList.Add(cs);
            this.Dataclass.MadeShiduchims.InsertOnSubmit(cs);
            selectedDetail = cs;
        }

        public void Remove(MadeShiduchim MadeShiduchim)
        {
            try
            {
                Dataclass.MadeShiduchims.DeleteOnSubmit(MadeShiduchim);
                Dataclass.SubmitChanges();
                this.MadeShiduchimList.Remove(MadeShiduchim);
                RefreshForm();
            }
            catch (Exception ex)
            {
                view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Made Shiduchim"),
                    Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }



        private bool IsUnsavedDataExists()
        {
            return MadeShiduchimList.Where(c => c.MadeShiduchim_Id == 0).Count() > 0;
        }

        public bool SaveForm(bool refreshDetailsForms)
        {
            try
            {
                if (GoodToCalculate(true))
                {
                    this.Dataclass.SubmitChanges();
                    view.DisplayMessage(Definitions.Message.SAVEDSUCCESSFULLYMSG, Definitions.MESSAGEBOXTITLE.SUCCESS);
                    RefreshForm();
                    if (refreshDetailsForms)
                    {
                        List<MadeShiduchim> details = Dataclass.MadeShiduchims.Where(F =>
                                F.MadeShiduchim_Id == selectedDetail.MadeShiduchim_Id).ToList();
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
                view.DisplayMessage(ex.Message + ex.StackTrace, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
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
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(MadeShiduchim));
            if (q.Count() > 0)
            {
                MadeShiduchim deletedObject = (MadeShiduchim)q.First();

                Dataclass.MadeShiduchims.DeleteOnSubmit(deletedObject);

                MadeShiduchimList.Remove(deletedObject);
            }
        }

        public void LoadDetails(MadeShiduchim accont)
        {
            selectedDetail = accont;
            if (detailsView == null)
                view.LoadDetails();
            else
            {
                detailsView.LoadDetails(selectedDetail);

            }
        }

        public void LoadDetailsView(IMadeShiduchimDetailsView _detailsView)
        {
            detailsView = _detailsView;

            detailsView.LoadFormLayout();
            detailsView.SetPermissions();
            detailsView.FillBoysList( "Name","FathersID", Dataclass.Families.ToList());
            detailsView.FillGirlsList("Name","FathersID", Dataclass.Families.ToList());
            detailsView.LoadMonth(Dataclass.Months.Select(R => R.Month1).Distinct().ToList());

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

            if (selectedDetail.Month == null)
                errorMsg += "Please Select a month" + Environment.NewLine + Environment.NewLine;



            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    detailsView.DisplayMessage("-----------Can not save this Made Shiduchim-----------" + Environment.NewLine + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }


        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "MadeShiduchim"), Definitions.MESSAGEBOXTITLE.WARNING.ToString()))
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
