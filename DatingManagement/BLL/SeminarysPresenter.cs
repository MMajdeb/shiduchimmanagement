using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Drawing;
using DatingManagement.DAL;


namespace DatingManagement
{
    public class SeminarysPresenter : BasePresenter
    {
        private ISeminarysView view;
        Seminary selectedDetail;

        List<Seminary> SeminaryList = new List<Seminary>();

        public SeminarysPresenter(ISeminarysView _view)
            : base(_view)
        {
            view = _view;

            this.SeminaryList = this.Dataclass.Seminarys.OrderBy(F => F.Seminary1).ToList();
        }

        public void HandleLoadForm()
        {
            view.SetDataSource(SeminaryList, false);

        }


        public void Add()
        {

            if (IsUnsavedDataExists())
            {
                view.DisplayMessage("Save first the Seminary", Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }

            AddNew();
            view.SetDataSource(SeminaryList, true);
        }

        private void AddNew()
        {
            Seminary cs = new Seminary();
            this.SeminaryList.Add(cs);
            this.Dataclass.Seminarys.InsertOnSubmit(cs);
            selectedDetail = cs;
        }

        public void Remove(Seminary Seminary)
        {
            try
            {
                Dataclass.Seminarys.DeleteOnSubmit(Seminary);
                Dataclass.SubmitChanges();
                this.SeminaryList.Remove(Seminary);
                RefreshForm();
            }
            catch (Exception ex)
            {
                view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Seminary"), Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }

        public void CompareName(Seminary TbTehnicean)
        {
            if (TbTehnicean == null) return;
            if (IsExisting(TbTehnicean))
            {
                view.DisplayMessage(String.Format(Definitions.Message.ALREADYEXISTING, "Seminary", TbTehnicean.Seminary1), Definitions.MESSAGEBOXTITLE.WARNING);
                view.disableSave();
                return;
            }

            view.enableSave();
        }

        public bool IsExisting(Seminary TbTehnicean)
        {
            string NameToCompare = TbTehnicean.Seminary1.Trim();

            //Looks for the deleted object in the Dataclass that match the name
            var deleted = Dataclass.GetChangeSet().Deletes.Where(C => C.GetType() == typeof(Seminary)).ToList();
            foreach (Seminary cst in deleted)
            {
                if (cst.Seminary1 == NameToCompare)
                {
                    return true;
                }
            }
            //Search for the existing category in the the database
            var acc = (from C in Dataclass.Seminarys
                       where C.Seminary1 == NameToCompare
                       && C.Seminary_Id != TbTehnicean.Seminary_Id
                       select C.Seminary_Id);


            string Name = NameToCompare;

            if (acc != null && acc.Count() > 0)
            {
                return true;

            }
            return false;
        }

        private bool IsUnsavedDataExists()
        {
            return SeminaryList.Where(c => c.Seminary_Id == 0).Count() > 0;
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
            view.SetDataSource(SeminaryList, false);
        }

        public void RemoveNewAdded()
        {
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(Seminary));
            if (q.Count() > 0)
            {
                Seminary deletedObject = (Seminary)q.First();
                Dataclass.Seminarys.DeleteOnSubmit(deletedObject);
                SeminaryList.Remove(deletedObject);
            }
        }


        private bool GoodToCalculate(bool showMessage)
        {
            string errorMsg = "";

            if (selectedDetail.Seminary_Id == null)
                errorMsg += "Enter a name for the Seminary " + Environment.NewLine;


            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    view.DisplayMessage("Can not save the Seminary" + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }

        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "Seminary"),
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
