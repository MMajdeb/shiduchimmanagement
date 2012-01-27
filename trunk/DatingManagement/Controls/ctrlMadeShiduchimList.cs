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
    public partial class ctrlMadeShiduchimList : XtraForm, IMadeShiduchimListView
    {

        MadeShiduchimsListPresenter presenter;

        protected bool isChanged = false;
        protected bool AllowFormToClose = true;


        public event ChangesOnFormNotSaved FormModificationsNotSaved;
        public event RefreshFormEvent RefreshFormEvent;
        public event ChangesOnFormNotSaved ChangesOnFormNotSaved;
        public event FormModified FormModified;

        public ctrlMadeShiduchimList()
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

        }

        public void FillListInGrid(string columntofillingrid, string displaycolumnname, string valuecolumn, object data)
        {
            if (grvList.Columns[columntofillingrid] != null)
                grvList.Columns[columntofillingrid].ColumnEdit = Utils.LoadGridList(displaycolumnname, valuecolumn, data, false);
        }

        public void SetDataSource(List<DAL.MadeShiduchim> MadeShiduchimList, bool focusLastRow)
        {

            int i = grvList.FocusedRowHandle;
            grcList.DataSource = null;
            grcList.DataSource = MadeShiduchimList;
            //Focusing the row
            if (focusLastRow)
            {
                for (int row = 0; i < grvList.RowCount; row++)
                {
                    if (grvList.GetRow(row) != null)
                    {
                        if (((MadeShiduchim)grvList.GetRow(row)).MadeShiduchim_Id == 0)
                        {
                            grvList.FocusedRowHandle = row;
                            return;
                        }
                    }
                }
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
            if (XtraMessageBox.Show("Are you sure you want to delete this MadeShiduchim", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MadeShiduchim detail = (MadeShiduchim)grvList.GetRow(grvList.FocusedRowHandle);
                presenter.Remove(detail);
            }
        }

        private void frmRoomDetails1_Load(object sender, EventArgs e)
        {

            this.presenter = new MadeShiduchimsListPresenter(this);
            presenter.HandleLoadForm();
        }

        void ctrlMadeShiduchimDetails1_MoveRowFocus(bool IsNext)
        {
            grvList.MoveNext();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.HandleLoadForm();
        }

        private void grvList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {


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
            List<MadeShiduchim> data = new List<MadeShiduchim>();

            for (int i = 0; i < grvList.DataRowCount; i++)
            {
                data.Add((MadeShiduchim)grvList.GetRow(i));
            }

            gridControlLite.DataSource = data;
            gridControlLite.ShowPrintPreview();

            //if (savedlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    grcList.ExportToXls(savedlg.FileName, new DevExpress.XtraPrinting.XlsExportOptions(DevExpress.XtraPrinting.TextExportMode.Value));
            //}
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.Save();
        }

        private void grvList_DoubleClick(object sender, EventArgs e)
        {
            ctrlMadeShiduchimDetails ctrlMadeShiduchimDetails1 = new ctrlMadeShiduchimDetails();

            ctrlMadeShiduchimDetails1.Presenter = presenter;
            presenter.LoadDetailsView(ctrlMadeShiduchimDetails1);

            MadeShiduchim client = (MadeShiduchim)grvList.GetRow(grvList.FocusedRowHandle);

            if (client == null)
                ctrlMadeShiduchimDetails1.Enabled = false;
            else
            {
                ctrlMadeShiduchimDetails1.Enabled = true;
                presenter.LoadDetails(client);
            }
            if (ctrlMadeShiduchimDetails1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RefreshData();
            }

        }

        public void LoadNewData(MadeShiduchim selectedDetail)
        {
            ctrlMadeShiduchimDetails ctrlMadeShiduchimDetails1 = new ctrlMadeShiduchimDetails();

            ctrlMadeShiduchimDetails1.Presenter = presenter;
            presenter.LoadDetailsView(ctrlMadeShiduchimDetails1);


            if (selectedDetail == null)
                ctrlMadeShiduchimDetails1.Enabled = false;
            else
            {
                ctrlMadeShiduchimDetails1.Enabled = true;
                presenter.LoadDetails(selectedDetail);
            }
            if (ctrlMadeShiduchimDetails1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RefreshData();
            }
        }
    }
}