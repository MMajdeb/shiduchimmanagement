using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingManagement
{
    public class Definitions
    {
        public const string defaultCustomer = "Walk In";
        public const string Inventory = "Inventory Modification";
        public const string loggerErrorMarkerStr = "Error";
        public const string NewRole = "New Role";
        public const string CustomerDefaultRef = "Verbal";
        public const string Customer = "Customer_";

        public const string UserRoleError = "The user has no role. Please talk with the administrator for that.";
        public const string UserDeleteError = "Can't delete the user with which you have logged in. Please log with a different user and try then";
        public const string RoleDeleteError = "Can't delete the Role because it has some users already attached. Please assign those user to a different Role and try again.";
        public const string RoleDeleteGridError = "Can't delete the Role because it has some Grid Layouts already attached. Do you want to delete them?.";
        public const string OpenImage = "Select an Image";

        public enum ReportNames
        {
            FisaService,
            Pontaj

        }
        
        public const string Reparatie_in_curs = "Reparatie in curs";
        public const string Reparie_finalizata = "Reparatie finalizata";
        public const string Reparative_imposibila = "Reparative imposibila";
        public const string Asteapta_piese = "Asteapta piese";
        public const string Trimis_in_garantie = "Trimis in garantie";



        public sealed class Messages
        {
            public const string Order_CustomerNotSelected = "Please select a customer ";
            public const string Order_ProductNotSelected = "Please select a product ";
            public const string Order_CloseOrder = "Do you want to close the order?";
            public const string Order_PriceisZero = "The item can't be added because the price is 0";
            public const string Order_QuantiyisZero = "The quantity is 0.";
            public const string Order_Quantiyexceeded = "Quantity exceeded";

            public const string Order_QuantiyInventoryZero = "The inventory quantity is 0. Do you want to reserve it?";
            public const string Order_CustomerTaxID = "Please enter the Tax ID first";
            public const string Order_LastProduct = "You are selling the last product. Are you sure it is in the inventory.";
            public const string ReportDesignError = "You must first design the report";
            public const string OrderTotalAmountError = "The Order amount is 0. Please add some products to the order";
            public const string ContainerTotalAmountError = "The Container amount is 0. Please add some Purchase Order";
            public const string ContainerAlreadyPayed = "The Container is already payed";

            public const string OrderPayError = "There is no Order selected. Please select some unpaid orders to pay";
            public const string OrderSelectError = "Please Select an order";
            public const string OrderIdError = "The Order no can't be found";
            public const string OrderCloseError = "The Order {0} can't be closed.";
            public const string OrderClosingReserve = "The Order can't be closed because it has some reserve items.";
            public const string OrderReturnError = "Can't return a reserve item.";
            public const string OrderBarcodeError = "Unable to find the product!!!!!";

            public const string DeliveringQuestion = "Does the order require transportation?";
            public const string SaveSuccesfully = "Save Succesfully";
            public const string SaveUnSuccesfully = "Save Unsuccesfully";
            public const string BarcodeQuestion = "Are you sure you want to remove the barcodes and create new ones?";
            public const string PurchaseOrderSupplierName = "Please select the supplier";
            public const string PurchaseOrderContainer = "Please select or add a container";
            public const string ClosingForm = "Are you sure you want to close?";
            public const string ContainerClosing = @"The Container Products will be added to the inventory. Are you sure the count is correct?";
            public const string ProdcutListExport = "Are you sure you want to close?";
            public const string PurchaseDeleteError = "The Purchase Order can't be deleted.";

            public const string ContainerONRoad = "Did you get the confirmation that the container has left the suppliers warehouse?";

            public const string SAVEERROR = "Some mandatory fields are null. The save cannot be resumed";
            public const string MISSINGFIELD = "Field {0} is mandatory";
            public const string SAVECHANGESTITLE = "Do You Want To Save?";
            public const string SAVENOTCOMPLETEMESSAGE = "Save Not Complete";
            public const string SAVEDSUCCESSFULLYMSG = "Saved successfully!";
            public const string DELETIONQUESTION = "Are you sure you want to delete?";
            public const string ALREADYEXISTING = "The {0} Code : {1} is already Exists";
            public const string CANBEDELETED = "This {0} can be deleted";

        }


        public enum MESSAGEBOXTITLE
        {
            WARNING,
            SUCCESS,
            ERROR,
            DELETE,
            QUESTION
        }

        public sealed class Message
        {
            public const string SAVEERROR = "Some mandatory fields are null. The save cannot be resumed";
            public const string MISSINGFIELD = "Field {0} is mandatory";
            public const string SAVECHANGESTITLE = "Do You Want To Save {0} ?";
            public const string SAVENOTCOMPLETEMESSAGE = "Save Not Complete";
            public const string SAVEDSUCCESSFULLYMSG = "Saved successfully!";
            public const string DELETIONQUESTION = "Are you sure you want to delete?";
            public const string ALREADYEXISTING = "The {0} : {1} is already Exists";
            public const string CODELENGHT = "The {0} is to long. Please insert a shorter one";
            public const string CANBEDELETED = "This {0} can be deleted";

            public const string UserRoleError = "The user has no role. Please talk with the administrator for that.";
            public const string UserDeleteError = "Can't delete the user with which you have logged in. Please log with a different user and try then";
            public const string RoleDeleteError = "Can't delete the Role because it has some users already attached. Please assign those user to a different Role and try again.";
            public const string RoleDeleteGridError = "Can't delete the Role because it has some Grid Layouts already attached. Do you want to delete them?.";
            public const string ReportDesignError = "You must first design the report";
            public const string AssetAccept = "Are you sure you all the details are corect?";
            public const string NoObjectFound = "No {0} has been found.";

            public static string OrderModifySameEntry = "You already have the same product added. Do you want to increase the quantity?";
            public const string NoRoomTypeFound = "Please add a room type before starting to create price types.";

            public static string RoomRateCreation = "Do you want to generate the room rates for all your room types now?";

            public static string SelectArrivalDate = "Please select an arrival date for the customer.";

            public static string SelectDepartureDate = "Please select a departure date or the number of rest nights for the customer.";

            public static string SelectRoomRateType = "Please select a room type.";

            public static string NoSelectedRooms = "You didn't select any room. Please select a room you want to reserve and then continue.";

            public static string LessRoomBeds = "The selected rooms have less beds than the person reserved for. Are you sure you want to continue?";

            public static string SelectRoom = "Please select a room in order togo further.";

            public static string LessRoomBedsforAdults = "The selected rooms have less beds for adults than the person reserved for. Are you sure you want to continue?";
            public static string LessRoomBedsforChilds = "The selected rooms have less beds for child(childrens) than the person reserved for. Are you sure you want to continue?";

            public static string UnabletoCheckin = "The arrival date of this reservation is not today. Please modify the arrival date first.";

            public static string RoomCheckOUT = "Select the room you want to check out";

            public static string ReservationEntry = "Order for reservation no. ";
            public static string ProductsCheckoutEntry = "Products consumed in room: ";

            public static string NoReservationSelected = "Please select a date and a room which already has an reservation in order to Check IN." + Environment.NewLine + "Otherwise add a Walk IN entry.";

            public static string RoomPropertiesDuplicateMenuProduct = "You already added this product. Please select another one.";

            public static string UnabletoFindcustomer = "Unable to find such customer.";

            public static string NOReminders = "No Reminders";
            public static string ShowReminders = "You have {0} reminders.";
            public static string OpenReminders = "Do You want to open the reminder form?";
        }
    }
}