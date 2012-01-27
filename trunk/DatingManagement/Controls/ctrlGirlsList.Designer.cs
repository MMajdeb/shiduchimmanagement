using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace DatingManagement
{
    partial class ctrlGirlsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemClienti = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ctrlGirlDetails1 = new DatingManagement.ctrlGirlDetails();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.grcList = new DevExpress.XtraGrid.GridControl();
            this.grvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolumnAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControlLite = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDelete,
            this.barButtonItemRefresh,
            this.barButtonItemClienti,
            this.btnSave});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemClienti)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Add";
            this.btnAdd.Glyph = global::DatingManagement.Properties.Resources.plus_32;
            this.btnAdd.Id = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Glyph = global::DatingManagement.Properties.Resources.delete_32;
            this.btnDelete.Id = 1;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Refresh";
            this.barButtonItemRefresh.Glyph = global::DatingManagement.Properties.Resources.refresh_32;
            this.barButtonItemRefresh.Id = 2;
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            this.barButtonItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefresh_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Glyph = global::DatingManagement.Properties.Resources.diskette_32;
            this.btnSave.Id = 7;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // barButtonItemClienti
            // 
            this.barButtonItemClienti.Caption = "Export Girls";
            this.barButtonItemClienti.Id = 5;
            this.barButtonItemClienti.Name = "barButtonItemClienti";
            this.barButtonItemClienti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(894, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 589);
            this.barDockControlBottom.Size = new System.Drawing.Size(894, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 547);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(894, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 547);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel1.ID = new System.Guid("fe0238c8-1304-42de-9a96-ce56daeb9683");
            this.dockPanel1.Location = new System.Drawing.Point(0, 280);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.AllowDockFill = false;
            this.dockPanel1.Options.AllowDockLeft = false;
            this.dockPanel1.Options.AllowDockRight = false;
            this.dockPanel1.Options.AllowDockTop = false;
            this.dockPanel1.Options.AllowFloating = false;
            this.dockPanel1.Options.FloatOnDblClick = false;
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 309);
            this.dockPanel1.Size = new System.Drawing.Size(894, 309);
            this.dockPanel1.Text = "Details";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.ctrlGirlDetails1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(888, 281);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ctrlGirlDetails1
            // 
            this.ctrlGirlDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlGirlDetails1.FormName = null;
            this.ctrlGirlDetails1.Location = new System.Drawing.Point(0, 0);
            this.ctrlGirlDetails1.Name = "ctrlGirlDetails1";
            this.ctrlGirlDetails1.Presenter = null;
            this.ctrlGirlDetails1.Size = new System.Drawing.Size(888, 281);
            this.ctrlGirlDetails1.TabIndex = 0;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // grcList
            // 
            this.grcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcList.Location = new System.Drawing.Point(0, 42);
            this.grcList.MainView = this.grvList;
            this.grcList.Name = "grcList";
            this.grcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1});
            this.grcList.ShowOnlyPredefinedDetails = true;
            this.grcList.Size = new System.Drawing.Size(894, 238);
            this.grcList.TabIndex = 6;
            this.grcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvList});
            // 
            // grvList
            // 
            this.grvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.grcolumnAge,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn18,
            this.gridColumn19});
            this.grvList.GridControl = this.grcList;
            this.grvList.IndicatorWidth = 50;
            this.grvList.Name = "grvList";
            this.grvList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvList.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvList.OptionsBehavior.Editable = false;
            this.grvList.OptionsView.ShowAutoFilterRow = true;
            this.grvList.OptionsView.ShowFooter = true;
            this.grvList.OptionsView.ShowGroupPanel = false;
            this.grvList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvList_FocusedRowChanged);
            this.grvList.DoubleClick += new System.EventHandler(this.grvList_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.Caption = "Last Name";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.SummaryItem.DisplayFormat = "Total Girls:";
            this.gridColumn1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mothers";
            this.gridColumn2.FieldName = "MotherName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn3.Caption = "Girls Name";
            this.gridColumn3.FieldName = "GirlsName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Region";
            this.gridColumn4.FieldName = "Region";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // grcolumnAge
            // 
            this.grcolumnAge.Caption = "Age";
            this.grcolumnAge.FieldName = "Age";
            this.grcolumnAge.Name = "grcolumnAge";
            this.grcolumnAge.Visible = true;
            this.grcolumnAge.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn5.Caption = "School";
            this.gridColumn5.FieldName = "School";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn6.Caption = "Seminar";
            this.gridColumn6.FieldName = "Seminary";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Home Phone";
            this.gridColumn7.FieldName = "HomePhone";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Work";
            this.gridColumn8.FieldName = "Work";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Height";
            this.gridColumn18.FieldName = "Height";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 9;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Graduate";
            this.gridColumn19.FieldName = "Graduate";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 10;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n2";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridControlLite
            // 
            this.gridControlLite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLite.Location = new System.Drawing.Point(0, 42);
            this.gridControlLite.MainView = this.gridView1;
            this.gridControlLite.Name = "gridControlLite";
            this.gridControlLite.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2,
            this.repositoryItemCheckEdit2});
            this.gridControlLite.ShowOnlyPredefinedDetails = true;
            this.gridControlLite.Size = new System.Drawing.Size(894, 238);
            this.gridControlLite.TabIndex = 12;
            this.gridControlLite.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlLite.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17});
            this.gridView1.GridControl = this.gridControlLite;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn9.Caption = "Last Name";
            this.gridColumn9.FieldName = "Name";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Mothers";
            this.gridColumn10.FieldName = "MotherName";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn11.Caption = "Girls Name";
            this.gridColumn11.FieldName = "GirlsName";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Region";
            this.gridColumn12.FieldName = "Region";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "gridColumn5";
            this.gridColumn13.FieldName = "Age";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 4;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn14.Caption = "School";
            this.gridColumn14.FieldName = "School";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 5;
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn15.Caption = "Seminar";
            this.gridColumn15.FieldName = "Seminary";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 6;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Home Phone";
            this.gridColumn16.FieldName = "HomePhone";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 7;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Work";
            this.gridColumn17.FieldName = "Work";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 8;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "n2";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // ctrlGirlsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 589);
            this.Controls.Add(this.grcList);
            this.Controls.Add(this.gridControlLite);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ctrlGirlsList";
            this.Load += new System.EventHandler(this.frmRoomDetails1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClienti;
        
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private GridControl grcList;
        private GridView grvList;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn grcolumnAge;
        private ctrlGirlDetails ctrlGirlDetails1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private GridControl gridControlLite;
        private GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
         
    }
}
