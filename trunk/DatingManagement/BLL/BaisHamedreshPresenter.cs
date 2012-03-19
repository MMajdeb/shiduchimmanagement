using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Drawing;
using DatingManagement.DAL;


namespace DatingManagement
{
    public class BaisHamedreshPresenter : BasePresenter
    {
        private IBaisHamedreshsView view;
        BaisHamedresh selectedDetail;

        List<BaisHamedresh> BaisHamedreshList = new List<BaisHamedresh>();

        public BaisHamedreshPresenter(IBaisHamedreshsView _view)
            : base(_view)
        {
            view = _view;

           
        }

        public void HandleLoadForm()
        {
            this.BaisHamedreshList = this.Dataclass.BaisHamedreshes.OrderBy(R=>R.BaisHamedresh1).ToList();
            view.SetDataSource(BaisHamedreshList, false);

        }


        public void Add()
        {

            if (IsUnsavedDataExists())
            {
                view.DisplayMessage("Save first the Bais Hamedresh", Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }

            AddNew();
            view.SetDataSource(BaisHamedreshList, true);
        }

        private void AddNew()
        {
            BaisHamedresh cs = new BaisHamedresh();
            this.BaisHamedreshList.Add(cs);
            this.Dataclass.BaisHamedreshes.InsertOnSubmit(cs);
            selectedDetail = cs;
        }

        public void Remove(BaisHamedresh BaisHamedresh)
        {
            try
            {
                Dataclass.BaisHamedreshes.DeleteOnSubmit(BaisHamedresh);
                Dataclass.SubmitChanges();
                this.BaisHamedreshList.Remove(BaisHamedresh);
                RefreshForm();
            }
            catch (Exception ex)
            {
                view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Bais Hamedresh"), Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }

        public void CompareName(BaisHamedresh TbTehnicean)
        {
            if (TbTehnicean == null) return;
            if (IsExisting(TbTehnicean))
            {
                view.DisplayMessage(String.Format(Definitions.Message.ALREADYEXISTING, "Bais Hamedresh", TbTehnicean.BaisHamedresh1), Definitions.MESSAGEBOXTITLE.WARNING);
                view.disableSave();
                return;
            }

            view.enableSave();
        }

        public bool IsExisting(BaisHamedresh TbTehnicean)
        {
            string NameToCompare = TbTehnicean.BaisHamedresh1.Trim();

            //Looks for the deleted object in the Dataclass that match the name
            var deleted = Dataclass.GetChangeSet().Deletes.Where(C => C.GetType() == typeof(BaisHamedresh)).ToList();
            foreach (BaisHamedresh cst in deleted)
            {
                if (cst.BaisHamedresh1 == NameToCompare)
                {
                    return true;
                }
            }
            //Search for the existing category in the the database
            var acc = (from C in Dataclass.BaisHamedreshes
                       where C.BaisHamedresh1 == NameToCompare
                       && C.BaisHamedresh_Id != TbTehnicean.BaisHamedresh_Id
                       select C.BaisHamedresh_Id);


            string Name = NameToCompare;

            if (acc != null && acc.Count() > 0)
            {
                return true;

            }
            return false;
        }

        private bool IsUnsavedDataExists()
        {
            return BaisHamedreshList.Where(c => c.BaisHamedresh_Id == 0).Count() > 0;
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
            view.SetDataSource(BaisHamedreshList, false);
        }

        public void RemoveNewAdded()
        {
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(BaisHamedresh));
            if (q.Count() > 0)
            {
                BaisHamedresh deletedObject = (BaisHamedresh)q.First();
                Dataclass.BaisHamedreshes.DeleteOnSubmit(deletedObject);
                BaisHamedreshList.Remove(deletedObject);
            }
        }


        private bool GoodToCalculate(bool showMessage)
        {
            string errorMsg = "";

            if (selectedDetail.BaisHamedresh1 == null)
                errorMsg += "Enter a name for the Bais Hamedresh " + Environment.NewLine;


            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    view.DisplayMessage("Can not save the Bais Hamedresh" + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }

        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "Bais Hamedresh"),
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
