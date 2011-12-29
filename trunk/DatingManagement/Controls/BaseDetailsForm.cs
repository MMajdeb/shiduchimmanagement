using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace DatingManagement
{
    public partial class BaseDetailsForm : DevExpress.XtraEditors.XtraForm, IBaseView
    {

        protected bool isChanged = false;
        protected bool AllowFormToClose = true;
        private BasePresenter presenter;
        BaseDetailCtrl _ctrl;

        public event ChangesOnFormNotSaved FormModificationsNotSaved;
        public event RefreshFormEvent RefreshFormEvent;
        public event ChangesOnFormNotSaved ChangesOnFormNotSaved;
        public event FormModified FormModified;

        public BaseDetailsForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public BaseDetailsForm(BaseDetailCtrl ctrl)
        {

            InitializeComponent();
            this.Controls.Add(ctrl);
            this.Text = ctrl.FormName;

            this.Width = ctrl.Width;
            this.Height = ctrl.Height;
            ctrl.Dock = DockStyle.Fill;
            ctrl.FormClosing += new FormClosing(ctrl_FormClosing);
            ctrl.FormModified += new FormModified(ctrl_FormModified);
            _ctrl = ctrl;
        }

        void ctrl_FormModified(bool isModifed, object form)
        {
            if (FormModified != null)
                FormModified(isModifed, form);
        }

        public BaseDetailsForm(BaseDetailCtrl ctrl, bool noBorder)
        {
            InitializeComponent();
            this.Controls.Add(ctrl);
            this.Text = ctrl.FormName;

            if (noBorder)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.StartPosition = FormStartPosition.CenterParent;
            }

            this.Width = ctrl.Width;
            this.Height = ctrl.Height;
            ctrl.Dock = DockStyle.Fill;
            ctrl.FormClosing += new FormClosing(ctrl_FormClosing);
            ctrl.FormModified += new FormModified(ctrl_FormModified);

        }

        void ctrl_FormClosing(bool IsDialogOk)
        {
            if (IsDialogOk)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        #region IBaseView Members

        public void DisplayMessage(string message, Definitions.MESSAGEBOXTITLE title)
        {
            MessageBox.Show(message, title.ToString());
        }

        public void ResetChange()
        {
            isChanged = false;
            FormModified(isChanged, this);
        }

        public void NotifyChange()
        {
            isChanged = true;
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
        public void FillListInGrid(string columntofillingrid, string displaycolumnname, string valuecolumn, object data)
        {

        }
        #endregion

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            //if (this.AllowFormToClose)
            //{
            //    if (MessageBox.Show(String.Format(InventoryManagement_DAL.Message.SAVECHANGESTITLE, this.Text)
            //        , "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == System.Windows.Forms.DialogResult.Yes)

            //    else
            //        AllowFormToClose = true;

            //}
            //e.Cancel = !AllowFormToClose;
        }

        #region IBaseView Members


        public void SetChangedStatus(bool p)
        {
            isChanged = p;
        }

        #endregion

        bool _NoBorder = false;

        public bool NoBorder
        {
            get { return _NoBorder; }
            set { _NoBorder = value; }
        }

        private void BaseDetailsForm_KeyUp(object sender, KeyEventArgs e)
        {

            //if (   e.KeyCode == Keys.Escape)
            //{
            //    if (MessageBox.Show("Do you want to close the form?", "Closing", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //        this.Close();
            //    }
            //}

            //_ctrl.KeyPressed(e.KeyCode);
        }


        public void KeyPressed(object key)
        {

        }
    }
}