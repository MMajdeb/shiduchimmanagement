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
using System.IO;


namespace DatingManagement
{
    public partial class ctrlBoysList : XtraForm, IBoyListView
    {

        BoysListPresenter presenter;

        protected bool isChanged = false;
        protected bool AllowFormToClose = true;


        public event ChangesOnFormNotSaved FormModificationsNotSaved;
        public event RefreshFormEvent RefreshFormEvent;
        public event ChangesOnFormNotSaved ChangesOnFormNotSaved;
        public event FormModified FormModified;

        public ctrlBoysList()
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
            presenter.LoadDetailsView(ctrlBoysDetails1);
        }

        public void FillListInGrid(string columntofillingrid, string displaycolumnname, string valuecolumn, object data)
        {
            if (grvList.Columns[columntofillingrid] != null)
                grvList.Columns[columntofillingrid].ColumnEdit = Utils.LoadGridList(displaycolumnname, valuecolumn, data, false);
        }

        public void SetDataSource(List<DAL.Boy> BoyList, bool focusLastRow)
        {
            int i = grvList.FocusedRowHandle;
            grcList.DataSource = null;
            grcList.DataSource = BoyList;
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
            frmBoysDetails frm = new frmBoysDetails();
            frm.Presenter = presenter;
            presenter.LoadDetailsView(frm);
            presenter.Add();
            frm.ShowDialog();


        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to delete this Boy", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Boy detail = (Boy)grvList.GetRow(grvList.FocusedRowHandle);
                presenter.Remove(detail);
            }
        }

        private void frmRoomDetails1_Load(object sender, EventArgs e)
        {

            this.presenter = new BoysListPresenter(this, ctrlBoysDetails1);

            this.ctrlBoysDetails1.Presenter = presenter;
            this.ctrlBoysDetails1.MoveRowFocus += new MoveGridFocusNext(ctrlBoysDetails1_MoveRowFocus);
            ctrlBoysDetails1.Enabled = false;
            presenter.HandleLoadForm();
        }

        void ctrlBoysDetails1_MoveRowFocus(bool IsNext)
        {
            grvList.MoveNext();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.HandleLoadForm();
        }

        private void grvList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            Boy client = (Boy)grvList.GetRow(grvList.FocusedRowHandle);

            if (client == null)
                ctrlBoysDetails1.Enabled = false;
            else
            {
                ctrlBoysDetails1.Enabled = true;
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
            if (File.Exists(Utils.GetReportPath(DatingManagement.Utils.Reports.BoysReport)))
            {
                SaveFileDialog savedlg = new SaveFileDialog();
                // savedlg.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                savedlg.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                List<Boy> data = new List<Boy>();

                for (int i = 0; i < grvList.DataRowCount; i++)
                {
                    data.Add((Boy)grvList.GetRow(i));
                }

                XtraReport1 XReport = new XtraReport1();
                XReport.LoadLayout(Utils.GetReportPath(DatingManagement.Utils.Reports.BoysReport));
                XReport.DataSource = data;
                XReport.ExportToPdf(savedlg.FileName);
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.Save();
        }

        private void grvList_DoubleClick(object sender, EventArgs e)
        {

            Boy detail = (Boy)grvList.GetRow(grvList.FocusedRowHandle);
            frmBoysDetails frm = new frmBoysDetails();
            frm.Presenter = presenter;
            presenter.LoadDetailsView(frm);
            presenter.LoadPopupDetailsForm(detail);
            frm.ShowDialog();

        }

        private void barButtonItemPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (File.Exists(Utils.GetReportPath(DatingManagement.Utils.Reports.BoysReport)))
            {
                List<Boy> data = new List<Boy>();

                for (int i = 0; i < grvList.DataRowCount; i++)
                {
                    data.Add((Boy)grvList.GetRow(i));
                }

                XtraReport1 XReport = new XtraReport1();
                XReport.LoadLayout(Utils.GetReportPath(DatingManagement.Utils.Reports.BoysReport));
                XReport.DataSource = data;
                XReport.ShowPreview();
            }
        }




    }
}