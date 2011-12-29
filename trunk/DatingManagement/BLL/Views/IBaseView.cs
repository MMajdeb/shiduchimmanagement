using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DatingManagement
{
    public delegate void ChangesOnFormNotSaved(); // this event is used by baseform when form is closing n modifications not saved
    public delegate void RefreshFormEvent(); //this event is used by baseform to ask user if he wants to refresh form when changes exist
    public delegate void FormModified(bool isModifed, object form);
    public delegate void ParentKeyPressed(object key);
    public delegate void MoveGridFocusNext(bool IsNext);
   
    public interface IBaseView
    {
        void DisplayMessage(string message, Definitions.MESSAGEBOXTITLE title);
        // void LoadGridLayouts();
        void ResetChange();
        void NotifyChange();
        bool AskUser(string Message, string Title);
        bool AskUser(string Message, Definitions.MESSAGEBOXTITLE title);
        bool HasChanges();
        void AllowClosingForm();
        void DisallowClosingForm();
        //void KeyPressed(object key);
        event ChangesOnFormNotSaved ChangesOnFormNotSaved;
        event RefreshFormEvent RefreshFormEvent;
       // event ParentKeyPressed ParentKeyPressedEvent; 
        void FillListInGrid(string columntofillingrid, string displaycolumnname, string valuecolumn, object data);
        void KeyPressed(object key);
    }
}
