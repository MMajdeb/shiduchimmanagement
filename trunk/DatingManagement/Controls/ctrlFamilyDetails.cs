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
    public partial class ctrlFamilyDetails : BaseDetailCtrl, IFamilyDetailsView
    {
        DAL.Family detailObject;
        FamilyListPresenter presenter;
        public event MoveGridFocusNext MoveRowFocus;

        public FamilyListPresenter Presenter
        {
            get { return presenter; }
            set { presenter = value; }
        }

        bool isChanged = false;

        public ctrlFamilyDetails()
        {
            InitializeComponent();
        }

        public ctrlFamilyDetails(FamilyListPresenter _presenter)
        {
            InitializeComponent();
            presenter = _presenter;
            presenter.LoadDetailsView(this);
        }


        #region IRoomDetailsView Members

        public void LoadFormLayout()
        {

        }

        public void LoadDetails(Family _selectedDetail)
        {
            detailObject = _selectedDetail;
            this.familyBindingSource.Clear();
            this.familyBindingSource.Add(detailObject);
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
            FathersIDSpinEdit.Select();
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


        public void LoadMechitunem(System.Data.Linq.EntitySet<Mechitunem> entitySet)
        {
            grcMechitunem.DataSource = entitySet;
        }

        public void LoadGirls(System.Data.Linq.EntitySet<Girl> entitySet)
        {
            grcGirls.DataSource = entitySet;
        }

        public void LoadBoys(System.Data.Linq.EntitySet<Boy> entitySet)
        {
            grcBoys.DataSource = entitySet;
        }


        public void LoadRegions(List<string> list)
        {
            RegionComboBoxEdit.Properties.Items.AddRange(list);
        }

        public void LoadCountries(List<string> list)
        {
            CountryComboBoxEdit.Properties.Items.AddRange(list);
        }

        public void LoadHamedresh(List<string> list)
        {
            BaisHamedreshComboBoxEdit.Properties.Items.AddRange(list);
        }


        public void LoadHeight(List<string> list)
        {
            repositoryItemComboBoxHeight.Items.AddRange(list);
            gridColumnBoyHeight.ColumnEdit = repositoryItemComboBoxHeight;
        }

        public void LoadYeshiva(List<string> list)
        {
            repositoryItemComboBoxYeshiva.Items.AddRange(list);
            gridColumnYeshiva.ColumnEdit = repositoryItemComboBoxYeshiva;

        }


        public void LoadBaisHamedresh(List<string> list)
        {
            repositoryItemComboBoxBaisHamedresh.Items.AddRange(list);
            gridColumnBaisMedresh.ColumnEdit = repositoryItemComboBoxYeshiva;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CloseForm(false);
            presenter.CloseForm(false);
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

        private void btnOpenBoy_Click(object sender, EventArgs e)
        {
            if (grvBoys.GetRow(grvBoys.FocusedRowHandle) != null)
            {
                BaseDetailsForm frm = new BaseDetailsForm();
                ctrlBoysDetails ctrl = new ctrlBoysDetails();
                BoysListPresenter presenterFamily = new BoysListPresenter(ctrl);
                ctrl.Presenter = presenterFamily;
                presenterFamily.LoadDetailsView(ctrl);
                                presenterFamily.LoadDetails(((Boy)grvBoys.GetRow(grvBoys.FocusedRowHandle)).BoysID);
                frm = new BaseDetailsForm(ctrl);
                frm.ShowDialog();
            }
        }

        private void btnOpenGirl_Click(object sender, EventArgs e)
        {
            if (grvGirls.GetRow(grvGirls.FocusedRowHandle) != null)
            {
                BaseDetailsForm frm = new BaseDetailsForm();
                ctrlGirlDetails ctrl = new ctrlGirlDetails();
                GirlsListPresenter presenterFamily = new GirlsListPresenter(ctrl);
                ctrl.Presenter = presenterFamily;
                presenterFamily.LoadDetailsView(ctrl);

                presenterFamily.LoadDetails(((Girl)grvGirls.GetRow(grvGirls.FocusedRowHandle)).GirlsID);
                frm = new BaseDetailsForm(ctrl);
                frm.ShowDialog();
            }
        }

        private void BaisHamedreshComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to add to selection?" + Environment.NewLine +
                                   "Press Yes to add, press No to replace.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                presenter.ModifyBaisHamedresh(true, BaisHamedreshComboBoxEdit.Text);
            }
            else
                presenter.ModifyBaisHamedresh(false, BaisHamedreshComboBoxEdit.Text);
        }
    }
}