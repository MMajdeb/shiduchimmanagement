using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 


namespace DatingManagement
{
    public delegate void ChangesOnDetailFormNotSaved(); // this event is used by baseform when form is closing n modifications not saved
    public delegate void RefreshDetailFormEvent(); //this event is used by baseform to ask user if he wants to refresh form when changes exist
    public delegate void DetailFormModified(bool isModifed);

    public interface IBaseDetailsView:IBaseView
    {
        //void DisplayMessage(string message, Definitions.MESSAGEBOXTITLE title);
        //// void LoadGridLayouts();
        //void ResetChange();
        //void NotifyChange();
        //bool AskUser(string Message, string Title);
        //bool HasChanges();
        //void AllowClosingForm();
        //void DisallowClosingForm();
        void SetPermissions();
        event ChangesOnDetailFormNotSaved ChangesOnDetailFormNotSaved;
        event RefreshDetailFormEvent RefreshDetailFormEvent;
       
    }
}
