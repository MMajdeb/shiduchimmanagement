using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.Linq;
using System.Linq;
using DevExpress.XtraEditors;

using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Menu;
using DevExpress.XtraLayout;
using System.Drawing;
using DevExpress.XtraEditors.Repository;

using System.Reflection;

namespace DatingManagement
{
    public static class Utils
    {
        public enum Reports
        {
            FamilyReport,
            BoysReport,
            GirlsReport,
            MadeShiduchim

        }
        public static DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            LoadGridList(string displayColumn, string valueColumn, object columnData, bool IsReadOnly)
        {
            return LoadGridList(displayColumn, valueColumn, columnData, IsReadOnly, false, null);
        }

        public static DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            LoadGridList(string displayColumn, string valueColumn, object columnData, bool IsReadOnly, bool addDeleteButton, ButtonPressedEventHandler buttonEvent)
        {
            DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repWarehouse = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            repWarehouse.AutoHeight = false;
            repWarehouse.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo(displayColumn, displayColumn, 
                                      20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, 
                                      DevExpress.Data.ColumnSortOrder.None)});

            repWarehouse.NullText = "";
            repWarehouse.DataSource = columnData;
            repWarehouse.DisplayMember = displayColumn;
            repWarehouse.ValueMember = valueColumn;

            if (addDeleteButton)
            {
                repWarehouse.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close));
                repWarehouse.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(buttonEvent);
            }
            return repWarehouse;
        }

        public static void LoadLookupList(ref DevExpress.XtraEditors.LookUpEdit repWarehouse, string displayColumn, string valueColumn, object columnData, bool IsReadOnly)
        {
            repWarehouse.Properties.AutoHeight = false;
            repWarehouse.Properties.Columns.Clear();
            repWarehouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo(displayColumn, displayColumn, 
                                      20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, 
                                      DevExpress.Data.ColumnSortOrder.None)});

            repWarehouse.Properties.DisplayMember = displayColumn;
            repWarehouse.Properties.ValueMember = valueColumn;
            repWarehouse.Properties.DataSource = columnData;
            //return repWarehouse;
        }



        public static DevExpress.XtraGrid.Views.Grid.GridView AddRepository(DevExpress.XtraGrid.Views.Grid.GridView Grid)
        {
            if (Grid != null)
            {

                DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repImage = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
                DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextDouble = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
                DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextInt = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
                DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repData = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
                DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repBoolean = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
                repTextInt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                repTextInt.Mask.UseMaskAsDisplayFormat = true;
                repTextInt.Mask.EditMask = "n0";

                repTextDouble.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                repTextDouble.Mask.UseMaskAsDisplayFormat = true;
                repTextDouble.Mask.EditMask = "f3";


                repImage.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;

                foreach (DevExpress.XtraGrid.Columns.GridColumn column in Grid.Columns)
                {
                    if (column.GetType() != typeof(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit))
                    {
                        if (column.ColumnType.FullName.Contains(System.TypeCode.DateTime.ToString())) column.ColumnEdit = repData;

                        else if (column.ColumnType.FullName.Contains(System.TypeCode.Double.ToString())) column.ColumnEdit = repTextDouble;

                        else if (column.ColumnType.FullName.Contains(System.TypeCode.Decimal.ToString())) column.ColumnEdit = repTextDouble;

                        else if (column.ColumnType.FullName.Contains(System.TypeCode.Int32.ToString())) column.ColumnEdit = repTextInt;

                        else if (column.ColumnType.FullName.Contains(System.TypeCode.Boolean.ToString())) column.ColumnEdit = repBoolean;

                        else if (column.ColumnType.FullName.Contains("System.Drawing.Bitmap")) column.ColumnEdit = repImage;
                    }
                }
                return Grid;
            }
            else return null;
        }



        //public static void LoadLayout(DevExpress.XtraGrid.Views.Grid.GridView grid, string GridName)
        //{
        //    LoadLayout(grid, GridName, (int)DataLayer.ConnectedUser.User_id);
        //}

        //public static void LoadLayoutControl(DevExpress.XtraDataLayout.DataLayoutControl layout, string layoutName)
        //{
        //    LoadLayoutControl(layout, layoutName, (int)DataLayer.ConnectedUser.User_id);
        //}

        //public static void LoadLayoutControl(DevExpress.XtraLayout.LayoutControl layout, string layoutName)
        //{
        //    LoadLayoutControl(layout, layoutName, (int)DataLayer.ConnectedUser.User_id);
        //}

        //public static void LoadLayoutControl(Object layout, string layoutName, int UserID)
        //{
        //    LoadLayoutFromFile(layout, layoutName, UserID);
        //}

        //public static void LoadLayoutFromDB(Object layout, string layoutName, int UserID)
        //{
        //    //NovaHospitality dataclass = new NovaHospitality(DataLayer.ConnectionString);

        //    //var GridList = from G in dataclass.GridsLayouts
        //    //               where G.GridName == layoutName && G.UserId == UserID
        //    //               select G;

        //    //if (GridList.Count() > 0)
        //    //{
        //    //    byte[] grLayout = GridList.First().GridLayoutData.ToArray();
        //    //    MemoryStream grdMemoryStream = new MemoryStream(grLayout);

        //    //    grdMemoryStream.Seek(0, SeekOrigin.Begin);
        //    //    if (layout is DevExpress.XtraDataLayout.DataLayoutControl) ((DevExpress.XtraDataLayout.DataLayoutControl)layout).RestoreLayoutFromStream(grdMemoryStream);
        //    //    else if (layout is DevExpress.XtraLayout.LayoutControl) ((DevExpress.XtraLayout.LayoutControl)layout).RestoreLayoutFromStream(grdMemoryStream);
        //    //}
        //}

        //public static void LoadLayoutFromFile(Object layout, string layoutName, int UserID)
        //{
        //    object Originallayout = layout;


        //    string path = DataLayer.GetLayoutPath(layoutName);
        //    if (File.Exists(path))
        //    {
        //        try
        //        {

        //            var q = DataLayer.CacheLayouts.Where(R => R.Grid_name == layoutName);

        //            if (layout is DevExpress.XtraDataLayout.DataLayoutControl)
        //                ((DevExpress.XtraDataLayout.DataLayoutControl)layout).RestoreLayoutFromStream(new MemoryStream(q.First().GridData));
        //            else if (layout is DevExpress.XtraLayout.LayoutControl)
        //                ((DevExpress.XtraLayout.LayoutControl)layout).RestoreLayoutFromStream(new MemoryStream(q.First().GridData));
        //        }
        //        catch (Exception ex)
        //        {
        //            File.Delete(path);
        //            SaveLayout(Originallayout, UserID, layoutName, false);
        //            layout = Originallayout;
        //        }

        //    }
        //    else
        //        SaveLayout(layout, UserID, layoutName, false);
        //}


        //public static void LoadLayout(DevExpress.XtraGrid.Views.Grid.GridView GridData, string GridName, int UserID)
        //{
        //    LoadGridLayoutFromFile(GridData, GridName, UserID, true);
        //}

        //public static void LoadLayout(DevExpress.XtraGrid.Views.Grid.GridView GridData, string GridName, int UserID, bool UseEmbeddedNavigator)
        //{
        //    LoadGridLayoutFromFile(GridData, GridName, UserID, UseEmbeddedNavigator);
        //}

        //public static void LoadGridLayoutFromFile(DevExpress.XtraGrid.Views.Grid.GridView GridData, string GridName, int UserID, bool UseEmbeddedNavigator)
        //{
        //    AddRepository(GridData);

        //    GridData.OptionsView.ColumnAutoWidth = false;
        //    List<DevExpress.XtraGrid.Columns.GridColumn> colList = new List<DevExpress.XtraGrid.Columns.GridColumn>();

        //    foreach (DevExpress.XtraGrid.Columns.GridColumn col in GridData.Columns)
        //    { colList.Add(col); }


        //    int columnsNO = GridData.Columns.Count;


        //    XtraGridContextMenu griXtraMenu = new XtraGridContextMenu();
        //    GridData.GridControl.ContextMenuStrip = griXtraMenu;
        //    griXtraMenu.SourceGrid = GridData.GridControl;
        //    string path = Application.LocalUserAppDataPath + "\\Design\\" + GridName + ".xml";

        //    if (!File.Exists(path))
        //    {

        //        GridData.OptionsView.ShowAutoFilterRow = false;
        //        GridData.OptionsView.ShowGroupPanel = false;
        //        GridData.OptionsView.ShowFooter = false;
        //        GridData.OptionsView.EnableAppearanceEvenRow = true;
        //        GridData.GridControl.UseEmbeddedNavigator = false;

        //        if (GridData.Columns.Count != 0)
        //            SaveGridLayout(GridData, GridName);
        //    }
        //    else
        //    {
        //        var q = DataLayer.CacheLayouts.Where(R => R.Grid_name == GridName);

        //        if (q.Count() > 0)
        //        {
        //            try
        //            {
        //                GridData.Columns.Clear();
        //                GridData.RestoreLayoutFromStream(new MemoryStream(q.First().GridData), DevExpress.Utils.OptionsLayoutBase.FullLayout);
        //                GridData.GridControl.UseEmbeddedNavigator = UseEmbeddedNavigator;
        //            }
        //            catch (Exception ex)
        //            {
        //                GridData.Columns.Clear();
        //                GridData.RestoreLayoutFromXml(path, DevExpress.Utils.OptionsLayoutBase.FullLayout);
        //                GridData.GridControl.UseEmbeddedNavigator = UseEmbeddedNavigator;
        //            }
        //        }
        //        else
        //        {
        //            GridData.Columns.Clear();
        //            GridData.RestoreLayoutFromXml(path, DevExpress.Utils.OptionsLayoutBase.FullLayout);
        //            GridData.GridControl.UseEmbeddedNavigator = UseEmbeddedNavigator;
        //        }
        //    }

        //    if (GridData.Columns.ColumnByFieldName("Is_active") != null)
        //    {
        //        GridData.Columns["Is_active"].Visible = AdministrationParameters.GetBoolParameter(AdministrationParameters.Parameters.ShowIsActiveColumn, false);
        //    }

        //    GridData.GridControl.Name = GridName;
        //}

        //public static void LoadLayoutFromDB(DevExpress.XtraGrid.Views.Grid.GridView GridData, string GridName, int UserID)
        //{
        //    AddRepository(GridData);
        //    NovaHospitality dataclass = new NovaHospitality(DataLayer.ConnectionString);

        //    GridData.OptionsView.ColumnAutoWidth = false;
        //    List<DevExpress.XtraGrid.Columns.GridColumn> colList = new List<DevExpress.XtraGrid.Columns.GridColumn>();

        //    foreach (DevExpress.XtraGrid.Columns.GridColumn col in GridData.Columns)
        //    { colList.Add(col); }


        //    int columnsNO = GridData.Columns.Count;

        //    var gridVS = from G in dataclass.Grids_layout_tbl
        //                 where G.Grid_name.Equals(GridName) && G.User_id == UserID
        //                 select G.Updated_on;

        //    XtraGridContextMenu griXtraMenu = new XtraGridContextMenu();
        //    GridData.GridControl.ContextMenuStrip = griXtraMenu;
        //    griXtraMenu.SourceGrid = GridData.GridControl;

        //    if (gridVS.Count() == 0)
        //    {
        //        GridData.OptionsView.ShowAutoFilterRow = false;
        //        GridData.OptionsView.ShowGroupPanel = false;
        //        GridData.OptionsView.ShowFooter = false;
        //        GridData.OptionsView.EnableAppearanceEvenRow = true;
        //        GridData.GridControl.UseEmbeddedNavigator = false;

        //        if (GridData.Columns.Count != 0)
        //            SaveGridLayout(GridData, GridName);
        //    }

        //    else if (gridVS.Count() > 0)
        //    {
        //        var GridList = from G in dataclass.Grids_layout_tbl
        //                       where G.Grid_name.Equals(GridName) && G.User_id == UserID
        //                       select G;

        //        GridData.Columns.Clear();

        //        GridData.RestoreLayoutFromXml(GridList.First().Grid_layout_path, DevExpress.Utils.OptionsLayoutBase.FullLayout);
        //        GridData.GridControl.UseEmbeddedNavigator = GridList.First().Is_MenuEnabled == null ? true : (bool)GridList.First().Is_MenuEnabled;
        //    }
        //}

        //public static void SaveGridLayout(DevExpress.XtraGrid.Views.Grid.GridView grid, string layoutControl_Name)
        //{
        //    SaveLayout(grid, (int)DataLayer.ConnectedUser.User_id, layoutControl_Name, true);
        //}

        //public static void SaveDataLayout(DevExpress.XtraDataLayout.DataLayoutControl grid, string layoutControl_Name)
        //{
        //    SaveLayout(grid, (int)DataLayer.ConnectedUser.User_id, layoutControl_Name, true);
        //}

        //public static void SaveDataLayout(DevExpress.XtraLayout.LayoutControl grid, string layoutControl_Name)
        //{
        //    SaveLayout(grid, (int)DataLayer.ConnectedUser.User_id, layoutControl_Name, true);
        //}

        // public static void SaveLayout(Object GridData, int UserID, string GridName, bool isGrid)
        //{
        //    Serev dataclass = new NovaHospitality(DataLayer.ConnectionString);


        //    string path = Application.LocalUserAppDataPath + "\\Design\\" + GridName + ".xml";
        //    MemoryStream grdMemoryStream = new MemoryStream();
        //    byte[] abyt = new byte[] { };

        //    if (GridData is DevExpress.XtraGrid.Views.Grid.GridView)
        //        ((DevExpress.XtraGrid.Views.Grid.GridView)GridData).SaveLayoutToXml(path, DevExpress.Utils.OptionsLayoutBase.FullLayout);


        //    if (GridData is DevExpress.XtraDataLayout.DataLayoutControl)
        //        ((DevExpress.XtraDataLayout.DataLayoutControl)GridData).SaveLayoutToXml(path);


        //    else if (GridData is DevExpress.XtraLayout.LayoutControl)
        //        ((DevExpress.XtraLayout.LayoutControl)GridData).SaveLayoutToXml(path);

        //    else if (GridData is DevExpress.XtraTreeList.TreeList)
        //        ((DevExpress.XtraTreeList.TreeList)GridData).SaveLayoutToXml(path);



        //    abyt = grdMemoryStream.GetBuffer();
        //    Binary fileBinary = new System.Data.Linq.Binary(abyt);

        //    var GridList = (from G in dataclass.Grids_layout_tbl
        //                    where
        //                        G.Grid_name.Equals(GridName) &&
        //                        G.User_id == UserID
        //                    select G).ToList();

        //    Grids_layout_tbl gridData;

        //    if (GridList != null && GridList.Count() > 0)
        //    {
        //        gridData = GridList.First();
        //        gridData.Is_grid = isGrid;
        //        gridData.Grid_layout_path = path;
        //        gridData.Grid_name = GridName;

        //        dataclass.SubmitChanges(true);
        //    }
        //    else
        //    {
        //        gridData = new Grids_layout_tbl();
        //        gridData.Grid_layout_path = path;
        //        gridData.User_id = UserID;
        //        gridData.Grid_name = GridName;
        //        gridData.Is_grid = isGrid;
        //        dataclass.Grids_layout_tbl.InsertOnSubmit(gridData);
        //        dataclass.SubmitChanges(true);
        //    }

        //    var q = DataLayer.CacheLayouts.Where(R => R.Grid_name == GridName);
        //    if (q.Count() > 0)
        //    {
        //        q.First().GridData = DataLayer.FileToByteArray(path);
        //    }
        //    else
        //    {
        //        DataLayer.CacheLayouts.Add(new GridLayoutLight() { ID = gridData.Grid_id, Grid_name = gridData.Grid_name, GridData = DataLayer.FileToByteArray(path) });
        //    }

        //}


        //public static List<string> GetSkinList()
        //{
        //    List<String> skins = new List<string>();
        //    foreach (DevExpress.Skins.SkinContainer cnt in DevExpress.Skins.SkinManager.Default.Skins)
        //    {
        //        skins.Add(cnt.SkinName);
        //    }

        //    return skins;
        //}


        //public static int GetAccesID(string AccesName)
        //{

        //    if (AccesName == Definitions.Permissions.Disabled.ToString()) return (int)Definitions.Permissions.Disabled;

        //    if (AccesName == Definitions.Permissions.Enabled.ToString()) return (int)Definitions.Permissions.Enabled;

        //    if (AccesName == Definitions.Permissions.Hide.ToString()) return (int)Definitions.Permissions.Hide;
        //    else return (int)Definitions.Permissions.Enabled;


        //}

        //public static void MoveFocus(DevExpress.XtraGrid.GridControl grid)
        //{
        //    DevExpress.XtraGrid.Views.Base.ColumnView view = (DevExpress.XtraGrid.Views.Base.ColumnView)grid.FocusedView;
        //    view.CloseEditor();
        //    view.UpdateCurrentRow();
        //}

        //public static void AdjustGridMenus(ref DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e, Object sender, string gridname)
        //{

        //    if (e.MenuType == GridMenuType.Column)
        //    {
        //        List<DXMenuItem> items = new List<DXMenuItem>();
        //        foreach (DXMenuItem item in e.Menu.Items)
        //            items.Add(item);

        //        DevExpress.Utils.Menu.DXMenuItem x = (from i in items
        //                                              where i.Caption == "Column Chooser"
        //                                              select i).FirstOrDefault();

        //        if (x != null)
        //        {
        //            //Dim role As ChinaDAL.Role = ChinaDAL.DataLayer.ConnectedUser.Role;
        //            //If role IsNot Nothing Then
        //            //    If role.RoleName <> ChinaDefinitions.SUPER_ADMIN Then
        //            //        x.Enabled = False
        //            //    End If
        //            //End If
        //        }
        //        DevExpress.XtraGrid.Menu.GridViewColumnMenu menu = (GridViewColumnMenu)e.Menu;
        //        DevExpress.Utils.Menu.DXMenuItem xitem = CreateCheckItem("Save Grid", //menu.Column,
        //                                                                FixedStyle.None, null,
        //                                                                sender, gridname);
        //        if (xitem != null)
        //            menu.Items.Add(xitem);

        //    }
        //}

        // //Create a menu item
        //private static DXMenuItem CreateCheckItem(string caption,
        //                     FixedStyle style, Image image, Object gridview, string gridname)
        //{
        //    // if (column == null) return null;

        //    DXMenuItem item = new DXMenuItem(caption, new EventHandler(OnFixedClick), image);
        //    GridView gv = (GridView)gridview;
        //    //''adding gridview and gridname to collection which is added to tag of the menuitem
        //    List<object> coll = new List<object>();
        //    coll.Add(gv);
        //    coll.Add(gridname);
        //    item.Tag = coll;
        //    return item;
        //}

        //private static DXMenuItem CreateCheckTreeItem(string caption,
        //                   FixedStyle style, Image image, Object gridview, string gridname)
        //{
        //    // if (column == null) return null;

        //    DXMenuItem item = new DXMenuItem(caption, new EventHandler(OnTreeFixedClick), image);
        //    TreeList gv = (TreeList)gridview;
        //    //''adding gridview and gridname to collection which is added to tag of the menuitem
        //    List<object> coll = new List<object>();
        //    coll.Add(gv);
        //    coll.Add(gridname);
        //    item.Tag = coll;
        //    return item;
        //}

        ////Menu item click handler
        //private static void OnFixedClick(object sender, EventArgs e)
        //{
        //    DXMenuItem item = (DXMenuItem)sender;
        //    List<object> coll = (List<object>)item.Tag;
        //    SaveGridLayout((GridView)coll[0], coll[1].ToString());
        //}


        //private static void OnTreeFixedClick(object sender, EventArgs e)
        //{
        //    DXMenuItem item = (DXMenuItem)sender;
        //    List<object> coll = (List<object>)item.Tag;
        //    SaveDataLayout((TreeList)coll[0], coll[1].ToString());
        //}


        //public static void AdjustLayoutMenus(ref DevExpress.XtraLayout.LayoutMenuEventArgs e, Object sender, string Layoutname)
        //{

        //    DXMenuItem xitem = new DXMenuItem("Save Layout", new EventHandler(OnSaveLayoutClick), null);
        //    List<object> coll = new List<object>();
        //    coll.Add(sender);
        //    coll.Add(Layoutname);
        //    xitem.Tag = coll;
        //    e.Menu.Items.Add(xitem);

        //}

        //private static void OnSaveLayoutClick(object sender, EventArgs e)
        //{
        //    DXMenuItem item = (DXMenuItem)sender;
        //    List<object> coll = (List<object>)item.Tag;


        //    //if (coll[0] is DevExpress.XtraDataLayout.DataLayoutControl)
        //    //   SaveDataLayout((DevExpress.XtraDataLayout.DataLayoutControl)coll[0], coll[1].ToString());
        //    //else if (coll[0] is DevExpress.XtraLayout.LayoutControl)
        //    SaveDataLayout((DevExpress.XtraLayout.LayoutControl)coll[0], coll[1].ToString());

        //}

        //public static bool PrintReport(Definitions.ReportNames ReportName, object ReportData)
        //{
        //    Reports_layout_tbl report = ReportsWriter.GetReport(ReportName.ToString());

        //    if (report.ReportData != null)
        //    {
        //        XtraReport1 xReport = new XtraReport1();

        //        xReport.LoadLayout(report.ReportData);
        //        xReport.DataSource = ReportData;

        //        xReport.ShowPreview();

        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show(Definitions.Messages.ReportDesignError, "Error");
        //        return false;
        //    }
        //}

        //public static void ExportGRidData(DevExpress.XtraGrid.GridControl grid)
        //{

        //    try
        //    {

        //        frmExportSelection selection = new frmExportSelection();
        //        if (selection.ShowDialog() == DialogResult.OK)
        //        {
        //            switch ((Definitions.ExportingTypes)selection.ExportingType)
        //            {
        //                case Definitions.ExportingTypes.Excel_xlsx:

        //                    grid.ExportToXlsx(ShowSaveFileDialog("xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*"));
        //                    break;
        //                case Definitions.ExportingTypes.Excel:
        //                    grid.ExportToXls(ShowSaveFileDialog("xls files (*.xls)|*.xls|All files (*.*)|*.*"));
        //                    break;
        //                case Definitions.ExportingTypes.HTML:
        //                    grid.ExportToHtml(ShowSaveFileDialog("html files (*.html)|*.html|All files (*.*)|*.*"));
        //                    break;
        //                case Definitions.ExportingTypes.Mht:
        //                    grid.ExportToMht(ShowSaveFileDialog("mht files (*.mht)|*.mht|All files (*.*)|*.*"));
        //                    break;
        //                case Definitions.ExportingTypes.PDF:
        //                    grid.ExportToPdf(ShowSaveFileDialog("pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"));
        //                    break;
        //                case Definitions.ExportingTypes.Rtf:
        //                    grid.ExportToRtf(ShowSaveFileDialog("rtf files (*.rtf)|*.rtf|All files (*.*)|*.*"));
        //                    break;
        //                case Definitions.ExportingTypes.CSV:
        //                    grid.ExportToText(ShowSaveFileDialog("txt files (*.txt)|*.txt|All files (*.*)|*.*"));
        //                    break;
        //                default:
        //                    break;
        //            }

        //        }
        //    }
        //    catch (Exception ex) { }

        //}

        //private static string ShowSaveFileDialog(string filter)
        //{
        //    SaveFileDialog saveDlg = new SaveFileDialog();
        //    saveDlg.Filter = filter;
        //    saveDlg.ShowDialog();
        //    return saveDlg.FileName;
        //}

        ////internal static RepositoryItemLookUpEdit LoadButtonGridList()
        ////{
        ////    DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
        ////    DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();

        ////    repositoryItemLookUpEdit1.AutoHeight = false;
        ////    repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        ////    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "OPEN", -1, true, true, false,
        ////        DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), 
        ////        serializableAppearanceObject1, "", "OPEN", null, false),
        ////    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "CheckIN", -1, true, true, false,
        ////        DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), 
        ////        serializableAppearanceObject1, "", "CheckIN", null, false)});

        ////    repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
        ////    repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
        ////    return repositoryItemLookUpEdit1;
        ////    //repositoryItemLookUpEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemLookUpEdit1_ButtonClick);
        ////}

        //internal static RepositoryItemButtonEdit LoadButtonGridList(string caption)
        //{
        //    RepositoryItemButtonEdit ri = new RepositoryItemButtonEdit();

        //    ri.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;

        //    ri.Buttons[0].Caption = caption;
        //    return ri;
        //}



        internal static string GetReportPath(Reports reports)
        {
            return Application.StartupPath + "\\Reports" + reports.ToString() + ".rpx";
             
        }
    }

    public class MenuInfo
    {
        public MenuInfo(GridColumn column, FixedStyle style)
        {
            this.Column = column;
            this.Style = style;
        }

        public FixedStyle Style;
        public GridColumn Column;
    }
}
