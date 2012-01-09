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
    public partial class ctrlBoysDetails : BaseDetailCtrl, IBoyDetailsView
    {
        DAL.Boy detailObject;
        BoysListPresenter presenter;
        public event MoveGridFocusNext MoveRowFocus;
        bool isLoading = false;

        public BoysListPresenter Presenter
        {
            get { return presenter; }
            set { presenter = value; }
        }

        bool isChanged = false;

        public ctrlBoysDetails()
        {
            InitializeComponent();
        }

        public ctrlBoysDetails(BoysListPresenter _presenter)
        {
            InitializeComponent();
            presenter = _presenter;
            presenter.LoadDetailsView(this);

        }


        #region IRoomDetailsView Members

        public void LoadFormLayout()
        {

        }

        public void LoadDetails(Boy _selectedDetail)
        {
            isLoading = true;
            detailObject = _selectedDetail;
            this.boyBindingSource.Clear();
            this.boyBindingSource.Add(detailObject);
            dataLayoutControl1.DataSource = detailObject;

            isLoading = false;
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
            FamilyTextEdit.Select();
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

        public void LoadHeight(List<string> list)
        {
            HeightComboBoxEdit.Properties.Items.AddRange(list);
        }

        public void LoadYeshiva(List<string> list)
        {
            YeshivaComboBoxEdit.Properties.Items.AddRange(list);
        }

        public void FillFamilyList(string p, string p_2, List<Family> list)
        {
            Utils.LoadLookupList(ref FathersIDLookUpEdit, p, p_2, list, false);
        }

        private void BirthDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            presenter.UpdateAge((DateTime)BirthDateDateEdit.EditValue);
        }

        private void YeshivaComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            if (XtraMessageBox.Show("Do you want to add to selection?" + Environment.NewLine +
                                    "Press Yes to add, press No to replace.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                presenter.ModifyYeshiva(true, YeshivaComboBoxEdit.Text);
            }
            else
                presenter.ModifyYeshiva(false, YeshivaComboBoxEdit.Text);
        }

        private void btnOpenFamily_Click(object sender, EventArgs e)
        {
            BaseDetailsForm frm = new BaseDetailsForm();

            ctrlFamilyDetails ctrl = new ctrlFamilyDetails();
            FamilyListPresenter presenterFamily = new FamilyListPresenter(ctrl);
            ctrl.Presenter = presenterFamily;
            presenterFamily.LoadDetailsView(ctrl);
            presenterFamily.LoadDetails((int)FathersIDLookUpEdit.EditValue);


            frm = new BaseDetailsForm(ctrl);
            frm.ShowDialog();
        }

        private void FathersIDLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            presenter.LoadFamily((int)FathersIDLookUpEdit.EditValue);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CloseForm(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (presenter.Save())
            {
                this.CloseForm(false);
                presenter.CloseForm(false);
            }
        }


        public void ShowPanel()
        {
            panelControl1.Visible = true;
        }
    }
}