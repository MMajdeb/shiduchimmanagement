using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Drawing;
using DatingManagement.DAL;


namespace DatingManagement
{
    public class HeightsPresenter : BasePresenter
    {
        private IHeightsView view;
        Height selectedDetail;

        List<Height> HeightList = new List<Height>();

        public HeightsPresenter(IHeightsView _view)
            : base(_view)
        {
            view = _view;

            this.HeightList = this.Dataclass.Heights.ToList();
        }

        public void HandleLoadForm()
        {
            view.SetDataSource(HeightList, false);

        }


        public void Add()
        {

            if (IsUnsavedDataExists())
            {
                view.DisplayMessage("Save first the Height", Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }

            AddNew();
            view.SetDataSource(HeightList, true);
        }

        private void AddNew()
        {
            Height cs = new Height();
            this.HeightList.Add(cs);
            this.Dataclass.Heights.InsertOnSubmit(cs);
            selectedDetail = cs;
        }

        public void Remove(Height Height)
        {
            try
            {
                Dataclass.Heights.DeleteOnSubmit(Height);
                Dataclass.SubmitChanges();
                this.HeightList.Remove(Height);
                RefreshForm();
            }
            catch (Exception ex)
            {
                view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Height"), Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }

        public void CompareName(Height TbTehnicean)
        {
            if (TbTehnicean == null) return;
            if (IsExisting(TbTehnicean))
            {
                view.DisplayMessage(String.Format(Definitions.Message.ALREADYEXISTING, "Height", TbTehnicean.Height1), Definitions.MESSAGEBOXTITLE.WARNING);
                view.disableSave();
                return;
            }

            view.enableSave();
        }

        public bool IsExisting(Height TbTehnicean)
        {
            string NameToCompare = TbTehnicean.Height1.Trim();

            //Looks for the deleted object in the Dataclass that match the name
            var deleted = Dataclass.GetChangeSet().Deletes.Where(C => C.GetType() == typeof(Height)).ToList();
            foreach (Height cst in deleted)
            {
                if (cst.Height1 == NameToCompare)
                {
                    return true;
                }
            }
            //Search for the existing category in the the database
            var acc = (from C in Dataclass.Heights
                       where C.Height1 == NameToCompare
                       && C.Height_Id != TbTehnicean.Height_Id
                       select C.Height_Id);


            string Name = NameToCompare;

            if (acc != null && acc.Count() > 0)
            {
                return true;

            }
            return false;
        }

        private bool IsUnsavedDataExists()
        {
            return HeightList.Where(c => c.Height_Id == 0).Count() > 0;
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
            view.SetDataSource(HeightList, false);
        }

        public void RemoveNewAdded()
        {
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(Height));
            if (q.Count() > 0)
            {
                Height deletedObject = (Height)q.First();
                Dataclass.Heights.DeleteOnSubmit(deletedObject);
                HeightList.Remove(deletedObject);
            }
        }


        private bool GoodToCalculate(bool showMessage)
        {
            string errorMsg = "";

            if (selectedDetail.Height1 == null)
                errorMsg += "Enter a name for the Height " + Environment.NewLine;


            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    view.DisplayMessage("Can not save the Height" + Environment.NewLine + errorMsg,
                        Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }

        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "Height"),
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
