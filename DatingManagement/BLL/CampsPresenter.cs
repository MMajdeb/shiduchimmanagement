using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Drawing;
using DatingManagement.DAL;


namespace DatingManagement
{
    public class CampsPresenter : BasePresenter
    {
        private ICampsView view;
        Camp selectedDetail;

        List<Camp> CampList = new List<Camp>();

        public CampsPresenter(ICampsView _view)
            : base(_view)
        {
            view = _view;

           
        }

        public void HandleLoadForm()
        {
            this.CampList = this.Dataclass.Camps.OrderBy(O=>O.Camp1).ToList();
            view.SetDataSource(CampList, false);

        }


        public void Add()
        {

            if (IsUnsavedDataExists())
            {
                view.DisplayMessage("Save first the Camp", Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }

            AddNew();
            view.SetDataSource(CampList, true);
        }

        private void AddNew()
        {
            Camp cs = new Camp();
            this.CampList.Add(cs);
            this.Dataclass.Camps.InsertOnSubmit(cs);
            selectedDetail = cs;
        }

        public void Remove(Camp Camp)
        {
            try
            {
                Dataclass.Camps.DeleteOnSubmit(Camp);
                Dataclass.SubmitChanges();
                this.CampList.Remove(Camp);
                RefreshForm();
            }
            catch (Exception ex)
            {
                view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Camp"), Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }

        public void CompareName(Camp TbTehnicean)
        {
            if (TbTehnicean == null) return;
            if (IsExisting(TbTehnicean))
            {
                view.DisplayMessage(String.Format(Definitions.Message.ALREADYEXISTING, "Camp", TbTehnicean.Camp1), Definitions.MESSAGEBOXTITLE.WARNING);
                view.disableSave();
                return;
            }

            view.enableSave();
        }

        public bool IsExisting(Camp TbTehnicean)
        {
            string NameToCompare = TbTehnicean.Camp1.Trim();

            //Looks for the deleted object in the Dataclass that match the name
            var deleted = Dataclass.GetChangeSet().Deletes.Where(C => C.GetType() == typeof(Camp)).ToList();
            foreach (Camp cst in deleted)
            {
                if (cst.Camp1 == NameToCompare)
                {
                    return true;
                }
            }
            //Search for the existing category in the the database
            var acc = (from C in Dataclass.Camps
                       where C.Camp1 == NameToCompare
                       && C.Camp_ID != TbTehnicean.Camp_ID
                       select C.Camp_ID);


            string Name = NameToCompare;

            if (acc != null && acc.Count() > 0)
            {
                return true;

            }
            return false;
        }

        private bool IsUnsavedDataExists()
        {
            return CampList.Where(c => c.Camp_ID == 0).Count() > 0;
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
            view.SetDataSource(CampList, false);
        }

        public void RemoveNewAdded()
        {
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(Camp));
            if (q.Count() > 0)
            {
                Camp deletedObject = (Camp)q.First();
                Dataclass.Camps.DeleteOnSubmit(deletedObject);
                CampList.Remove(deletedObject);
            }
        }


        private bool GoodToCalculate(bool showMessage)
        {
            string errorMsg = "";

            if (selectedDetail.Camp1 == null)
                errorMsg += "Enter a name for the Camp " + Environment.NewLine;


            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    view.DisplayMessage("Can not save the Camp" + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }

        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "Camp"),
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
