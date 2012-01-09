using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DatingManagement;
using System.Diagnostics;
using DatingManagement.DAL;

namespace DatingManagement
{
    public partial class ctrlMadeShiduchimDetails : XtraUserControl, IMadeShiduchimDetailsView
    {
        DAL.MadeShiduchim detailObject;
        MadeShiduchimsListPresenter presenter;
        public event MoveGridFocusNext MoveRowFocus;

        public MadeShiduchimsListPresenter Presenter
        {
            get { return presenter; }
            set { presenter = value; }
        }

        bool isChanged = false;

        public ctrlMadeShiduchimDetails()
        {
            InitializeComponent();
        }

        public ctrlMadeShiduchimDetails(MadeShiduchimsListPresenter _presenter)
        {
            InitializeComponent();
            presenter = _presenter;
            presenter.LoadDetailsView(this);
        }


        #region IRoomDetailsView Members

        public void LoadFormLayout()
        {

        }

        public void LoadDetails(MadeShiduchim _selectedDetail)
        {
            detailObject = _selectedDetail;
            this.madeShiduchimBindingSource.Clear();
            this.madeShiduchimBindingSource.Add(detailObject);
            dataLayoutControl1.DataSource = detailObject;
        }

        public void LoadPhoto(Bitmap bitmap)
        {
        }

        #endregion

        #region IBaseDetailsView Members



        public event ChangesOnDetailFormNotSaved ChangesOnDetailFormNotSaved;

        public event RefreshDetailFormEvent RefreshDetailFormEvent;

        #endregion


        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoveFocus();
            presenter.SaveForm(true);
        }

        private void MoveFocus()
        {
            YearTextEdit.Select();
        }

        private void barButtonItemSaveClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoveFocus();
            isChanged = presenter.SaveForm(false);

        }

        private void barButtonItemNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoveRowFocus(true);
        }

        private void barButtonItemPrevios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoveRowFocus(false);
        }

        private void frmCustomerDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            presenter.CloseForm(isChanged);
        }

        private void control_EditValueChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }


        public void SetPermissions()
        {

        }

        public void DisplayMessage(string message, Definitions.MESSAGEBOXTITLE title)
        {
            XtraMessageBox.Show(message);
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

        public void FillListInGrid(string columntofillingrid, string displaycolumnname, string valuecolumn, object data)
        {

        }

        public void KeyPressed(object key)
        {

        }


        public void FillBoysList(string p, string p_2, List<Family> list)
        {
            Utils.LoadLookupList(ref BoysSideLookUpEdit, p, p_2, list, false);
        }

        public void FillGirlsList(string p, string p_2, List<Family> list)
        {
            Utils.LoadLookupList(ref GirlsSideLookUpEdit, p, p_2, list, false);
        }

        public void FillMonthsList(string p, string p_2, List<Month> list)
        {
            Utils.LoadLookupList(ref MonthLookUpEdit, p, p_2, list, false);
        }
    }
}