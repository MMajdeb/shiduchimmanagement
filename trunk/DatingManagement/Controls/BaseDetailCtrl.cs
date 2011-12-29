using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors; 

namespace DatingManagement
{
    public delegate void FormClosing(bool IsDialogOk);
    public partial class
        BaseDetailCtrl : DevExpress.XtraEditors.XtraUserControl, IBaseView
    {
        protected bool isChanged = false;
        protected bool AllowFormToClose = true;
        private BasePresenter presenter;
        public int i = 0;
        public event ChangesOnFormNotSaved FormModificationsNotSaved;
        public event RefreshFormEvent RefreshFormEvent;
        public event ChangesOnFormNotSaved ChangesOnFormNotSaved;
        public event FormModified FormModified;
        public event FormClosing FormClosing;
        public event ParentKeyPressed ParentKeyPress;

        string _formName;
        public string FormName { get { return _formName; } set { _formName = value; } }

        public BaseDetailCtrl()
        {
            InitializeComponent();
        }

        public void MoveNextFocus()
        {
            // MoveFocus(true);
        }

        public void PreviosNextFocus()
        {
            //MoveFocus(false);
        }

        public void MoveFocus()
        {
            txtFocus.Select();
        }


        #region IBaseView Members

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

        public bool AskUser(string Message, string Title)
        {
            if (MessageBox.Show(Message, Title, MessageBoxButtons.OKCancel) == DialogResult.OK)
                return true;
            else return false;
        }

        public bool AskUser(string Message, Definitions.MESSAGEBOXTITLE title)
        {
            return AskUser(Message, title.ToString());
        }

        public bool HasChanges()
        {
            return isChanged;
        }

        public void CloseForm(bool IsDialogOk)
        {
            if (FormClosing != null)
                FormClosing(IsDialogOk);
        }

        public void AllowClosingForm()
        {
            AllowFormToClose = true;
        }

        public void DisallowClosingForm()
        {
            AllowFormToClose = false;
        }


        #endregion


        internal void Close()
        {
            if (FormClosing != null)
                FormClosing(true);
        }



        public void KeyPressed(object key)
        {
            if (ParentKeyPress != null)
                ParentKeyPress(key);
        }


        public void FillListInGrid(string columntofillingrid, string displaycolumnname, string valuecolumn, object data)
        {
        }
    }
}
