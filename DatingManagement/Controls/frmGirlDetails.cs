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
    public partial class frmGirlDetails : BaseDetailsForm, IGirlDetailsView
    {
        DAL.Girl detailObject;
        GirlsListPresenter presenter;
        public event MoveGridFocusNext MoveRowFocus;
        bool isLoading = false;

        public GirlsListPresenter Presenter
        {
            get { return presenter; }
            set { presenter = value; }
        }

        bool isChanged = false;

        public frmGirlDetails()
        {
            InitializeComponent();
        }

        public frmGirlDetails(GirlsListPresenter _presenter)
        {
            InitializeComponent();
            presenter = _presenter;
            presenter.LoadDetailsView(this);
        }


        #region IRoomDetailsView Members

        public void LoadFormLayout()
        {

        }

        public void LoadDetails(Girl _selectedDetail)
        {
            isLoading = true;
            detailObject = _selectedDetail;
            this.girlBindingSource.Clear();
            this.girlBindingSource.Add(detailObject);
            dataLayoutControl1.DataSource = detailObject;

            isLoading = false;
        }

        public void LoadDetails(Girl _selectedDetail, Family _selectedFamilyDetail)
        {
            isLoading = true;
            detailObject = _selectedDetail;
            this.girlBindingSource.Clear();
            this.girlBindingSource.Add(detailObject);
            dataLayoutControl1.DataSource = detailObject;

            this.familyBindingSource.Clear();
            this.familyBindingSource.Add(_selectedFamilyDetail);
            dataLayoutControl3.DataSource = _selectedFamilyDetail;

            gridControl1.DataSource = _selectedFamilyDetail.Mechitunems;
            this.panelControl1.Visible = true;
            this.Text = "Girl Name: " + _selectedDetail.Name;

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
            // YeshivaComboBoxEdit.Properties.Items.AddRange(list);
        }

        public void FillFamilyList(string p, string p_2, List<Family> list)
        {
            Utils.LoadLookupList(ref FathersIDLookUpEdit, p, p_2, list, false);
        }


        public void LoadSchools(List<string> list)
        {
            SchoolComboBoxEdit.Properties.Items.AddRange(list);
        }

        public void LoadSeminary(List<string> list)
        {
            SeminaryComboBoxEdit.Properties.Items.AddRange(list);
        }

        public void LoadCamps(List<string> list)
        {
            CampComboBoxEdit.Properties.Items.AddRange(list);
        }

        private void BirthDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            presenter.UpdateAge((DateTime)BirthDateDateEdit.EditValue);
        }

        private void FathersIDLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            presenter.LoadFamilyDetails((int)FathersIDLookUpEdit.EditValue);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (presenter.Save())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                presenter.CloseForm(false);
            }
        }

        public void ShowPanel()
        {
            panelControl1.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            presenter.RemoveNewAdded();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void CampComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show("Do you want to add to selection?" + Environment.NewLine +
                                    "Press Yes to add, press No to replace.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                presenter.ModifyCamp(true, CampComboBoxEdit.Text);
            }
            else
                presenter.ModifyCamp(false, CampComboBoxEdit.Text);
        }

        private void SchoolComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to add to selection?" + Environment.NewLine +
                                    "Press Yes to add, press No to replace.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                presenter.ModifySchool(true, SchoolComboBoxEdit.Text);
            }
            else
                presenter.ModifySchool(false, SchoolComboBoxEdit.Text);
        }

        private void SeminaryComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to add to selection?" + Environment.NewLine +
                                    "Press Yes to add, press No to replace.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                presenter.ModifySeminary(true, SeminaryComboBoxEdit.Text);
            }
            else
                presenter.ModifySeminary(false, SeminaryComboBoxEdit.Text);
        }

        public void LoadRegions(List<string> list)
        {
            RegionComboBoxEdit.Properties.Items.AddRange(list);
        }

        public void LoadCountries(List<string> list)
        {
            CountryComboBoxEdit.Properties.Items.AddRange(list);
        }

        public void LoadBaisHamedresh(List<string> list)
        {
            BaisHamedreshComboBoxEdit.Properties.Items.AddRange(list);
        }

        private void CountryComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to add to selection?" + Environment.NewLine +
                                             "Press Yes to add, press No to replace.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                presenter.ModifyCountry(true, CountryComboBoxEdit.Text);
            }
            else
                presenter.ModifyCountry(false, CountryComboBoxEdit.Text);
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