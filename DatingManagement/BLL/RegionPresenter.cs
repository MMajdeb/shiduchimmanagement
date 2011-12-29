using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Drawing;
using DatingManagement.DAL;


namespace DatingManagement
{
    public class RegionPresenter : BasePresenter
    {
        private IRegionsView view;
        DatingManagement.DAL.Region selectedDetail;

        List<DatingManagement.DAL.Region> RegionList = new List<DatingManagement.DAL.Region>();

        public RegionPresenter(IRegionsView _view)
            : base(_view)
        {
            view = _view;

            this.RegionList = this.Dataclass.Regions.ToList();
        }

        public void HandleLoadForm()
        {
            view.SetDataSource(RegionList, false);

        }


        public void Add()
        {

            if (IsUnsavedDataExists())
            {
                view.DisplayMessage("Save first the Region", Definitions.MESSAGEBOXTITLE.WARNING);
                return;
            }

            AddNew();
            view.SetDataSource(RegionList, true);
        }

        private void AddNew()
        {
            DatingManagement.DAL.Region cs = new DatingManagement.DAL.Region();
            this.RegionList.Add(cs);
            this.Dataclass.Regions.InsertOnSubmit(cs);
            selectedDetail = cs;
        }

        public void Remove(DatingManagement.DAL.Region Region)
        {
            try
            {
                Dataclass.Regions.DeleteOnSubmit(Region);
                Dataclass.SubmitChanges();
                this.RegionList.Remove(Region);
                RefreshForm();
            }
            catch (Exception ex)
            {
                view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "Region"), Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }

        public void CompareName(DatingManagement.DAL.Region TbTehnicean)
        {
            if (TbTehnicean == null) return;
            if (IsExisting(TbTehnicean))
            {
                view.DisplayMessage(String.Format(Definitions.Message.ALREADYEXISTING, "Region", TbTehnicean.Region1), Definitions.MESSAGEBOXTITLE.WARNING);
                view.disableSave();
                return;
            }

            view.enableSave();
        }

        public bool IsExisting(DatingManagement.DAL.Region TbTehnicean)
        {
            string NameToCompare = TbTehnicean.Region1.Trim();

            //Looks for the deleted object in the Dataclass that match the name
            var deleted = Dataclass.GetChangeSet().Deletes.Where(C => C.GetType() == typeof(DatingManagement.DAL.Region)).ToList();
            foreach (DatingManagement.DAL.Region cst in deleted)
            {
                if (cst.Region1 == NameToCompare)
                {
                    return true;
                }
            }
            //Search for the existing category in the the database
            var acc = (from C in Dataclass.Regions
                       where C.Region1 == NameToCompare
                       && C.Region_Id != TbTehnicean.Region_Id
                       select C.Region_Id);


            string Name = NameToCompare;

            if (acc != null && acc.Count() > 0)
            {
                return true;

            }
            return false;
        }

        private bool IsUnsavedDataExists()
        {
            return RegionList.Where(c => c.Region_Id == 0).Count() > 0;
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
            view.SetDataSource(RegionList, false);
        }

        public void RemoveNewAdded()
        {
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(DatingManagement.DAL.Region));
            if (q.Count() > 0)
            {
                DatingManagement.DAL.Region deletedObject = (DatingManagement.DAL.Region)q.First();
                Dataclass.Regions.DeleteOnSubmit(deletedObject);
                RegionList.Remove(deletedObject);
            }
        }


        private bool GoodToCalculate(bool showMessage)
        {
            string errorMsg = "";

            if (selectedDetail.Region1 == null)
                errorMsg += "Enter a name for the Region " + Environment.NewLine;


            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    view.DisplayMessage("Can not save the Region" + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }

        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "Region"),
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
