using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Drawing;
using DatingManagement.DAL;


namespace DatingManagement
{
    public class SchoolsPresenter : BasePresenter
    {
        private ISchoolsView view;
        School selectedDetail;

        List<School> SchoolList = new List<School>();

        public SchoolsPresenter(ISchoolsView _view)
            : base(_view)
        {
            view = _view;

            this.SchoolList = this.Dataclass.Schools.OrderBy(F => F.School1).ToList();
        }

        public void HandleLoadForm()
        {
            view.SetDataSource(SchoolList, false);

        }


        public void Add()
        {
            //if (IsUnsavedDataExists())
            //{
            //    view.DisplayMessage("Save first the School", Definitions.MESSAGEBOXTITLE.WARNING);
            //    return;
            //}

            AddNew();
            view.SetDataSource(SchoolList, true);
        }

        private void AddNew()
        {
            School cs = new School();
            this.SchoolList.Add(cs);
            this.Dataclass.Schools.InsertOnSubmit(cs);
            selectedDetail = cs;
        }

        public void Remove(School School)
        {
            try
            {
                Dataclass.Schools.DeleteOnSubmit(School);
                Dataclass.SubmitChanges();
                this.SchoolList.Remove(School);
                RefreshForm();
            }
            catch (Exception ex)
            {
                view.DisplayMessage(string.Format(Definitions.Messages.CANBEDELETED, "School"), Definitions.MESSAGEBOXTITLE.ERROR);

            }
        }

        public void CompareName(School TbTehnicean)
        {
            if (TbTehnicean == null) return;
            if (IsExisting(TbTehnicean))
            {
                view.DisplayMessage(String.Format(Definitions.Message.ALREADYEXISTING, "School", TbTehnicean.School1), Definitions.MESSAGEBOXTITLE.WARNING);
                view.disableSave();
                return;
            }

            view.enableSave();
        }

        public bool IsExisting(School TbTehnicean)
        {
            string NameToCompare = TbTehnicean.School1.Trim();

            //Looks for the deleted object in the Dataclass that match the name
            var deleted = Dataclass.GetChangeSet().Deletes.Where(C => C.GetType() == typeof(School)).ToList();
            foreach (School cst in deleted)
            {
                if (cst.School1 == NameToCompare)
                {
                    return true;
                }
            }
            //Search for the existing category in the the database
            var acc = (from C in Dataclass.Schools
                       where C.School1 == NameToCompare
                       && C.School_Id != TbTehnicean.School_Id
                       select C.School_Id);


            string Name = NameToCompare;

            if (acc != null && acc.Count() > 0)
            {
                return true;

            }
            return false;
        }

        private bool IsUnsavedDataExists()
        {
            return SchoolList.Where(c => c.School_Id == 0).Count() > 0;
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
            view.SetDataSource(SchoolList, false);
        }

        public void RemoveNewAdded()
        {
            var q = Dataclass.GetChangeSet().Inserts.Where(T => T.GetType() == typeof(School));
            if (q.Count() > 0)
            {
                School deletedObject = (School)q.First();
                Dataclass.Schools.DeleteOnSubmit(deletedObject);
                SchoolList.Remove(deletedObject);
            }
        }


        private bool GoodToCalculate(bool showMessage)
        {
            string errorMsg = "";

            if (selectedDetail.School1 == null)
                errorMsg += "Enter a name for the School " + Environment.NewLine;


            if (errorMsg == "")
                return true;
            else
            {
                if (showMessage)
                    view.DisplayMessage("Can not save the School" + Environment.NewLine + errorMsg, Definitions.MESSAGEBOXTITLE.ERROR);
                return false;
            }
        }

        public bool Save()
        {
            return SaveForm(false);
        }

        public void CloseForm(bool isChanged)
        {
            if (isChanged && view.AskUser(string.Format(Definitions.Message.SAVECHANGESTITLE, "School"),
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
