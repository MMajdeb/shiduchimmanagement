using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace DatingManagement
{
    partial class ctrlMadeShiduchimList
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
            this.components = new System.ComponentModel.Container();
            this.grcList = new DevExpress.XtraGrid.GridControl();
            this.grvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditBoysSide = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditGirlsSide = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemClienti = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemprintpreview = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridControlLite = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBoysSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditGirlsSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // grcList
            // 
            this.grcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcList.Location = new System.Drawing.Point(0, 40);
            this.grcList.MainView = this.grvList;
            this.grcList.Name = "grcList";
            this.grcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemLookUpEditBoysSide,
            this.repositoryItemLookUpEditGirlsSide});
            this.grcList.ShowOnlyPredefinedDetails = true;
            this.grcList.Size = new System.Drawing.Size(889, 741);
            this.grcList.TabIndex = 0;
            this.grcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvList});
            // 
            // grvList
            // 
            this.grvList.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.grvList.Appearance.FocusedRow.Options.UseFont = true;
            this.grvList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.grvList.Appearance.GroupRow.Options.UseFont = true;
            this.grvList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvList.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvList.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.grvList.Appearance.Row.Options.UseFont = true;
            this.grvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn13});
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
            this.gridColumn1.Caption = "Month";
            this.gridColumn1.FieldName = "MonthName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Year";
            this.gridColumn2.FieldName = "Year";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn3.Caption = "BoysSide";
            this.gridColumn3.ColumnEdit = this.repositoryItemLookUpEditBoysSide;
            this.gridColumn3.FieldName = "BoysSide";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.SummaryItem.DisplayFormat = "{0:c2}";
            this.gridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEditBoysSide
            // 
            this.repositoryItemLookUpEditBoysSide.AutoHeight = false;
            this.repositoryItemLookUpEditBoysSide.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditBoysSide.Name = "repositoryItemLookUpEditBoysSide";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Amount Boys";
            this.gridColumn4.DisplayFormat.FormatString = "c2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "AmountBoy";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.SummaryItem.DisplayFormat = "{0:c2}";
            this.gridColumn4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn5.Caption = "Girls Side";
            this.gridColumn5.ColumnEdit = this.repositoryItemLookUpEditGirlsSide;
            this.gridColumn5.FieldName = "GirlsSide";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.SummaryItem.DisplayFormat = "{0:c2}";
            this.gridColumn5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEditGirlsSide
            // 
            this.repositoryItemLookUpEditGirlsSide.AutoHeight = false;
            this.repositoryItemLookUpEditGirlsSide.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditGirlsSide.Name = "repositoryItemLookUpEditGirlsSide";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Amount Girl";
            this.gridColumn6.DisplayFormat.FormatString = "c2";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "AmountGirl";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.SummaryItem.DisplayFormat = "{0:c2}";
            this.gridColumn6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Shidduch Date";
            this.gridColumn13.FieldName = "ShiduchimDate";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 6;
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
            this.btnSave,
            this.barButtonItemprintpreview});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemClienti),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemprintpreview)});
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
            this.barButtonItemClienti.Caption = "Export";
            this.barButtonItemClienti.Id = 5;
            this.barButtonItemClienti.Name = "barButtonItemClienti";
            this.barButtonItemClienti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItemprintpreview
            // 
            this.barButtonItemprintpreview.Caption = "Print Preview";
            this.barButtonItemprintpreview.Id = 8;
            this.barButtonItemprintpreview.Name = "barButtonItemprintpreview";
            this.barButtonItemprintpreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemprintpreview_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(889, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 781);
            this.barDockControlBottom.Size = new System.Drawing.Size(889, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 741);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(889, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 741);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
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
            // gridControlLite
            // 
            this.gridControlLite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLite.Location = new System.Drawing.Point(0, 40);
            this.gridControlLite.MainView = this.gridView1;
            this.gridControlLite.Name = "gridControlLite";
            this.gridControlLite.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2,
            this.repositoryItemCheckEdit2,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControlLite.ShowOnlyPredefinedDetails = true;
            this.gridControlLite.Size = new System.Drawing.Size(889, 741);
            this.gridControlLite.TabIndex = 6;
            this.gridControlLite.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlLite.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridView1.GridControl = this.gridControlLite;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Month";
            this.gridColumn7.FieldName = "Month";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Year";
            this.gridColumn8.FieldName = "Year";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn9.Caption = "BoysSide";
            this.gridColumn9.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gridColumn9.FieldName = "BoysSide";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Amount Boys";
            this.gridColumn10.DisplayFormat.FormatString = "c2";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "AmountBoy";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn11.Caption = "Girls Side";
            this.gridColumn11.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.gridColumn11.FieldName = "GirlsSide";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Amount Girl";
            this.gridColumn12.DisplayFormat.FormatString = "c2";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn12.FieldName = "AmountGirl";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 5;
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
            // ctrlMadeShiduchimList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 781);
            this.Controls.Add(this.grcList);
            this.Controls.Add(this.gridControlLite);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ctrlMadeShiduchimList";
            this.Load += new System.EventHandler(this.frmRoomDetails1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBoysSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditGirlsSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridControl grcList;
        private GridView grvList;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClienti;
        private ctrlFamilyDetails ctrlContactDetails1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditBoysSide;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditGirlsSide;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private GridControl gridControlLite;
        private GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraBars.BarButtonItem barButtonItemprintpreview;
         
    }
}
