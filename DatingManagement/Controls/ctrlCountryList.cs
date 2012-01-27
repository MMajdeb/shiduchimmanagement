using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;


using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DatingManagement.DAL;

namespace DatingManagement
{
    public partial class ctrlCountryList : XtraForm, ICountrysView
    {

        CountryPresenter presenter;

        public ctrlCountryList()
        {
            InitializeComponent();
        }

        #region IEmployeeTypesView Members


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


        public void FillListInGrid(string columntofillingrid, string displaycolumnname, string valuecolumn, object data)
        {
            if (grvList.Columns[columntofillingrid] != null)
                grvList.Columns[columntofillingrid].ColumnEdit = Utils.LoadGridList(displaycolumnname, valuecolumn, data, false);
        }

        public void SetDataSource(List<Country> tehniceni, bool focusLastRow)
        {
            int i = grvList.FocusedRowHandle;
            grcList.DataSource = null;
            grcList.DataSource = tehniceni;
            //Focusing the row
            if (focusLastRow)
            {
                for (int row = 0; i < grvList.RowCount; row++)
                {
                    if (((Country)grvList.GetRow(row)).Country_Id == 0)
                    {
                        grvList.FocusedRowHandle = row;
                        return;
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
            if (XtraMessageBox.Show("Are you sure you want to delete this Country", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Country detail = (Country)grvList.GetRow(grvList.FocusedRowHandle);
                presenter.Remove(detail);
            }
        }



        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.RefreshForm();
        }



        private void frmRoomsPropertiesList_Load(object sender, EventArgs e)
        {
            this.presenter = new CountryPresenter(this);
            this.Text = "Country";
             
            presenter.HandleLoadForm();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            presenter.Save();
        }

        public void DisplayMessage(string message, Definitions.MESSAGEBOXTITLE title)
        {

        }

        public void ResetChange()
        {

        }

        public void NotifyChange()
        {

        }

        public bool AskUser(string Message, string Title)
        {
            return false;
        }

        public bool AskUser(string Message, Definitions.MESSAGEBOXTITLE title)
        {
            return false;
        }

        public bool HasChanges()
        {
            return false;
        }

        public void AllowClosingForm()
        {
        }

        public void DisallowClosingForm()
        {

        }

        public event ChangesOnFormNotSaved ChangesOnFormNotSaved;

        public event RefreshFormEvent RefreshFormEvent;

        public void KeyPressed(object key)
        {
         
        }


    }
}