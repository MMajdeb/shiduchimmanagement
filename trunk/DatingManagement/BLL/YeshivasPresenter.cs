using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Drawing;
using DatingManagement.DAL;


namespace DatingManagement
{
    public class YeshivasPresenter : BasePresenter
    {
        private IYeshivasView view;
        Yeshiva selectedDetail;

        List<Yeshiva> YeshivaList = new List<Yeshiva>();

        public YeshivasPresenter(IYeshivasView _view)
            : base(_view)
        {
            view = _view;

            this.YeshivaList = this.Dataclass.Yeshivas.OrderBy(F => F.Yeshiva1).ToList();
        }

        public void HandleLoadForm()
        {
            view.SetDataSource(YeshivaList, false);

        }


        public void Add()
        {

            if (IsUnsavedDataExists())
            {
                view.DisplayMessage("Save first the Yeshiva", Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }

            AddNew();
            view.SetDataSource(YeshivaList, true);
        }

        private void AddNew()
        {
            Yeshiva cs = new Yeshiva();
            this.YeshivaList.Add(cs);
            this.Dataclass.Yeshivas.InsertOnSubmit(cs);
            selectedDetail = cs;
        }

        public void Remove(Yeshiva Yeshiva)
        {
            try
            {
                Dataclass.Yeshivas.DeleteOnSubmit(Yeshiva);
                Dataclass.SubmitChanges();
                this.YeshivaList.Remove(Yeshiva);
                RefreshForm();
            }
            catch (Exception ex)
            {
                view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Yeshiva"), Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }

        public void CompareName(Yeshiva TbTehnicean)
        {
            if (TbTehnicean == null) return;
            if (IsExisting(TbTehnicean))
            {
                view.DisplayMessage(String.Format(Definitions.Message.ALREADYEXISTING, "Yeshiva", TbTehnicean.Yeshiva1), Definitions.MESSAGEBOXTITLE.WARNING);
                view.disableSave();
                return;
            }

            view.enableSave();
        }

        public bool IsExisting(Yeshiva TbTehnicean)
        {
            string NameToCompare = TbTehnicean.Yeshiva1.Trim();

            //Looks for the deleted object in the Dataclass that match the name
            var deleted = Dataclass.GetChangeSet().Deletes.Where(C => C.GetType() == typeof(Yeshiva)).ToList();
            foreach (Yeshiva cst in deleted)
            {
                if (cst.Yeshiva1 == NameToCompare)
                {
                    return true;
                }
            }
            //Search for the existing category in the the database
            var acc = (from C in Dataclass.Yeshivas
                       where C.Yeshiva1 == NameToCompare
                       && C.Yeshiva_Id != TbTehnicean.Yeshiva_Id
                       select C.Yeshiva_Id);


            string Name = NameToCompare;

            if (acc != null && acc.Count() > 0)
            {
                return true;

            }
            return false;
        }

        private bool IsUnsavedDataExists()
        {
            return YeshivaList.Where(c => c.Yeshiva_Id == 0).Count() > 0;
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
            view.SetDataSource(YeshivaList, false);
        }

        public void RemoveNewAdded()
        {
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(Yeshiva));
            if (q.Count() > 0)
            {
                Yeshiva deletedObject = (Yeshiva)q.First();
                Dataclass.Yeshivas.DeleteOnSubmit(deletedObject);
                YeshivaList.Remove(deletedObject);
            }
        }


        private bool GoodToCalculate(bool showMessage)
        {
            string errorMsg = "";

            if (selectedDetail.Yeshiva1 == null)
                errorMsg += "Enter a name for the Yeshiva " + Environment.NewLine;


            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    view.DisplayMessage("Can not save the Yeshiva" + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }

        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "Yeshiva"),
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
