using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Drawing;
using DatingManagement.DAL;


namespace DatingManagement
{
    public class MonthsPresenter : BasePresenter
    {
        private IMonthsView view;
        Month selectedDetail;

        List<Month> MonthList = new List<Month>();

        public MonthsPresenter(IMonthsView _view)
            : base(_view)
        {
            view = _view;

            this.MonthList = this.Dataclass.Months.OrderBy(F => F.Month1).ToList();
        }

        public void HandleLoadForm()
        {
            view.SetDataSource(MonthList, false);

        }


        public void Add()
        {

            if (IsUnsavedDataExists())
            {
                view.DisplayMessage("Save first the Month", Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }

            AddNew();
            view.SetDataSource(MonthList, true);
        }

        private void AddNew()
        {
            Month cs = new Month();
            this.MonthList.Add(cs);
            this.Dataclass.Months.InsertOnSubmit(cs);
            selectedDetail = cs;
        }

        public void Remove(Month Month)
        {
            try
            {
                Dataclass.Months.DeleteOnSubmit(Month);
                Dataclass.SubmitChanges();
                this.MonthList.Remove(Month);
                RefreshForm();
            }
            catch (Exception ex)
            {
                view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Month"), Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }

        public void CompareName(Month TbTehnicean)
        {
            if (TbTehnicean == null) return;
            if (IsExisting(TbTehnicean))
            {
                view.DisplayMessage(String.Format(Definitions.Message.ALREADYEXISTING, "Month", TbTehnicean.Month1), Definitions.MESSAGEBOXTITLE.WARNING);
                view.disableSave();
                return;
            }

            view.enableSave();
        }

        public bool IsExisting(Month TbTehnicean)
        {
            string NameToCompare = TbTehnicean.Month1.Trim();

            //Looks for the deleted object in the Dataclass that match the name
            var deleted = Dataclass.GetChangeSet().Deletes.Where(C => C.GetType() == typeof(Month)).ToList();
            foreach (Month cst in deleted)
            {
                if (cst.Month1 == NameToCompare)
                {
                    return true;
                }
            }
            //Search for the existing category in the the database
            var acc = (from C in Dataclass.Months
                       where C.Month1 == NameToCompare
                       && C.Months_Id != TbTehnicean.Months_Id
                       select C.Months_Id);


            string Name = NameToCompare;

            if (acc != null && acc.Count() > 0)
            {
                return true;

            }
            return false;
        }

        private bool IsUnsavedDataExists()
        {
            return MonthList.Where(c => c.Months_Id == 0).Count() > 0;
        }

        public bool SaveForm(bool refreshDetailsForms)
        {
            try
            {
                this.Dataclass.SubmitChanges();
                view.DisplayMessage(Definitions.Message.SAVEDSUCCESSFULLYMSG, Definitions.MESSAGEBOXTITLE.SUCCESS);
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
            view.SetDataSource(MonthList, false);
        }

        public void RemoveNewAdded()
        {
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(Month));
            if (q.Count() > 0)
            {
                Month deletedObject = (Month)q.First();
                Dataclass.Months.DeleteOnSubmit(deletedObject);
                MonthList.Remove(deletedObject);
            }
        }


        private bool GoodToCalculate(bool showMessage)
        {
            string errorMsg = "";

            if (selectedDetail.Month1 == null)
                errorMsg += "Enter a name for the Month " + Environment.NewLine;


            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    view.DisplayMessage("Can not save the Month" + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }

        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "Month"),
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
