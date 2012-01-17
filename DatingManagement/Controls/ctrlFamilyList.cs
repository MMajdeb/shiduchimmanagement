using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using DatingManagement.DAL;


namespace DatingManagement
{
    public partial class ctrlFamilyList : XtraForm, IFamilyListView
    {

        FamilyListPresenter presenter;

        protected bool isChanged = false;
        protected bool AllowFormToClose = true;


        public event ChangesOnFormNotSaved FormModificationsNotSaved;
        public event RefreshFormEvent RefreshFormEvent;
        public event ChangesOnFormNotSaved ChangesOnFormNotSaved;
        public event FormModified FormModified;

        public ctrlFamilyList()
        {
            InitializeComponent();
        }

        #region IFloorListView Members

        public void LoadGridLayout(string p)
        {
            grvList.OptionsBehavior.Editable = false;
        }

        public void RefreshData()
        {
            presenter.RefreshForm();
        }

        public void SetFocusToNewRow()
        {
            grvList.FocusedRowHandle = grvList.RowCount - 1;

        }

        public void disableSave()
        {

        }

        public void enableSave()
        {

        }

        public void LoadDetails()
        {
            presenter.LoadDetailsView(ctrlFamilyDetails1);
        }

        public void FillListInGrid(string columntofillingrid, string displaycolumnname, string valuecolumn, object data)
        {
            if (grvList.Columns[columntofillingrid] != null)
                grvList.Columns[columntofillingrid].ColumnEdit = Utils.LoadGridList(displaycolumnname, valuecolumn, data, false);
        }

        public void SetDataSource(List<DAL.Family> FamilyList, bool focusLastRow)
        {
            int i = grvList.FocusedRowHandle;
            grcList.DataSource = null;
            grcList.DataSource = FamilyList;
            //Focusing the row
            if (focusLastRow)
            {
                grvList.FocusedRowHandle = grvList.RowCount - 1;

            }
            else
                grvList.FocusedRowHandle = i;
        }

        #endregion


        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.Add();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to delete this Family", "Stergere", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Family detail = (Family)grvList.GetRow(grvList.FocusedRowHandle);
                presenter.Remove(detail);
            }
        }

        private void frmRoomDetails1_Load(object sender, EventArgs e)
        {

            this.presenter = new FamilyListPresenter(this, ctrlFamilyDetails1);

            this.ctrlFamilyDetails1.Presenter = presenter;
            this.ctrlFamilyDetails1.MoveRowFocus += new MoveGridFocusNext(ctrlFamilyDetails1_MoveRowFocus);
            ctrlFamilyDetails1.Enabled = false;
            presenter.HandleLoadForm();
        }

        void ctrlFamilyDetails1_MoveRowFocus(bool IsNext)
        {
            grvList.MoveNext();
        }



        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.HandleLoadForm();
        }

        private void grvList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            Family client = (Family)grvList.GetRow(grvList.FocusedRowHandle);

            if (client == null)
                ctrlFamilyDetails1.Enabled = false;
            else
            {
                ctrlFamilyDetails1.Enabled = true;
                presenter.LoadDetails(client);
            }
        }


        public void DisplayMessage(string message, Definitions.MESSAGEBOXTITLE title)
        {
            MessageBox.Show(message, title.ToString());
        }

        public void ResetChange()
        {
            isChanged = false;
            if (FormModified != null)
                FormModified(isChanged, this);
        }

        public void NotifyChange()
        {
            isChanged = true;
            if (FormModified != null)
                FormModified(isChanged, this);
        }

        public bool AskUser(string Message, Definitions.MESSAGEBOXTITLE title)
        {
            return AskUser(Message, title.ToString());
        }
        public bool AskUser(string Message, string Title)
        {
            if (MessageBox.Show(Message, Title, MessageBoxButtons.OKCancel) == DialogResult.OK)
                return true;
            else return false;
        }

        public bool HasChanges()
        {
            return isChanged;
        }

        public void AllowClosingForm()
        {
            AllowFormToClose = true;
        }

        public void DisallowClosingForm()
        {
            AllowFormToClose = false;
        }

        public void KeyPressed(object key)
        {

        }

        public void SetPermission()
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog savedlg = new SaveFileDialog();
            // savedlg.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            savedlg.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            List<Family> data = new List<Family>();

            for (int i = 0; i < grvList.DataRowCount; i++)
            {
                data.Add((Family)grvList.GetRow(i));
            }

            gridControlLite.DataSource = data;
            gridControlLite.ShowPrintPreview();

            //if (savedlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    gridControlLite.ExportToXls(savedlg.FileName, new DevExpress.XtraPrinting.XlsExportOptions(DevExpress.XtraPrinting.TextExportMode.Value));
            //}
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.Save();
        }

        private void btnAddBoys_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Family client = (Family)grvList.GetRow(grvList.FocusedRowHandle);

            if (client != null)
            {
                frmBoysDetails frm = new frmBoysDetails();
                BoysListPresenter boysPresenter = new BoysListPresenter(frm);
                frm.Presenter = boysPresenter;
                boysPresenter.LoadDetailsView(frm);
                boysPresenter.Add(client);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    presenter.HandleLoadForm();
            }

        }

        private void btnAddGirls_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Family client = (Family)grvList.GetRow(grvList.FocusedRowHandle);

            if (client != null)
            {
                frmGirlDetails frm = new frmGirlDetails();
                GirlsListPresenter girlsPresenter = new GirlsListPresenter(frm);
                frm.Presenter = girlsPresenter;
                girlsPresenter.LoadDetailsView(frm);
                girlsPresenter.Add(client);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    presenter.HandleLoadForm();
            }
        }
    }
}