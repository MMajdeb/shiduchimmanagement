using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel;
using System;
using DatingManagement.DAL;


namespace DatingManagement
{
    public delegate bool DoSave();
    public delegate T Create<T>();
    public delegate bool Remove<T>(T objToRemove);

    public abstract class BasePresenter  
    {
        IBaseView _view;
        bool _NewRowAdded = false;
        
        public bool HasChanges
        {
            get
            {
                int changes = 0;
                changes += this.Dataclass.GetChangeSet().Deletes.Count();
                changes += this.Dataclass.GetChangeSet().Inserts.Count();
                changes += this.Dataclass.GetChangeSet().Updates.Count();
                return (changes == 0);
            }
        }

        public BasePresenter(IBaseView View)
        {
            _view = View;
            _view.ChangesOnFormNotSaved += new ChangesOnFormNotSaved(view_ChangesOnFormNotSaved);
            _view.RefreshFormEvent += new RefreshFormEvent(view_RefreshFormEvent);
        }

         
        protected virtual bool HasAnyReferences(object objToremove)
        {
            return false;
        }

        protected void view_RefreshFormEvent()
        {
            if (_view.HasChanges())
            {
                if (_view.AskUser("There are changes which have not been saved.Do you want to refresh?", "Decide"))
                {
                    this.Dataclass = null;
                    RefreshForm();
                    _view.ResetChange();
                    _NewRowAdded = false;
                }
            }
        }

        protected void view_ChangesOnFormNotSaved()
        {
            if (Save())
            {
                CleanupOnSuccessfullSave();
                return;
            }
            _view.DisallowClosingForm();
        }

        private bool Save()
        {
            return true;
        }

        public abstract void RefreshForm();
      
        public void CleanupOnSuccessfullSave()
        {
            _view.AllowClosingForm();
            _view.ResetChange();
            _view.DisplayMessage(Definitions.Message.SAVEDSUCCESSFULLYMSG, Definitions.MESSAGEBOXTITLE.SUCCESS);
            _NewRowAdded = false;

        }

        public bool Execute(DoSave _save)
        {
            if (_save())
            {
                CleanupOnSuccessfullSave();
                return true;
            }
            return false;
        }

        protected void SetNewRowAddedToFalse()
        {
            _NewRowAdded = false;
        }

        ShiduchimDBDataContext _dataclass;
        public ShiduchimDBDataContext Dataclass
        {
            get
            {
                if (_dataclass == null)
                    this._dataclass = new ShiduchimDBDataContext(DataLayer.ConnectionString);

                return _dataclass;
            }
            set
            {
                if ((this._dataclass != value))
                {
                    this._dataclass = value;
                }
            }
        }


    }
}
