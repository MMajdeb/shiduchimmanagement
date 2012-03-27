namespace DatingManagement
{
    partial class MainForm
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnFamilies = new DevExpress.XtraBars.BarButtonItem();
            this.btnBoys = new DevExpress.XtraBars.BarButtonItem();
            this.btnGirls = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegions = new DevExpress.XtraBars.BarButtonItem();
            this.btnSchools = new DevExpress.XtraBars.BarButtonItem();
            this.btnCamps = new DevExpress.XtraBars.BarButtonItem();
            this.btnCountry = new DevExpress.XtraBars.BarButtonItem();
            this.btnSeminarys = new DevExpress.XtraBars.BarButtonItem();
            this.btnYeshivas = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaisHamedresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnMadeShiduchim = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemReportDesigner = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.TabManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnFamilies,
            this.btnBoys,
            this.btnGirls,
            this.btnRegions,
            this.btnSchools,
            this.btnCamps,
            this.btnCountry,
            this.btnSeminarys,
            this.btnYeshivas,
            this.btnBaisHamedresh,
            this.btnMadeShiduchim,
            this.barButtonItemReportDesigner});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.SelectedPage = this.ribbonPage1;
            this.ribbon.Size = new System.Drawing.Size(1133, 145);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnFamilies
            // 
            this.btnFamilies.Caption = "Families";
            this.btnFamilies.Glyph = global::DatingManagement.Properties.Resources.demographic_32;
            this.btnFamilies.Id = 1;
            this.btnFamilies.LargeGlyph = global::DatingManagement.Properties.Resources.demographic_32;
            this.btnFamilies.LargeWidth = 90;
            this.btnFamilies.Name = "btnFamilies";
            this.btnFamilies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFamilies_ItemClick);
            // 
            // btnBoys
            // 
            this.btnBoys.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoys.Appearance.Options.UseFont = true;
            this.btnBoys.Caption = "Boys";
            this.btnBoys.Id = 2;
            this.btnBoys.LargeGlyph = global::DatingManagement.Properties.Resources.admin_2_32;
            this.btnBoys.LargeWidth = 90;
            this.btnBoys.Name = "btnBoys";
            this.btnBoys.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBoys_ItemClick);
            // 
            // btnGirls
            // 
            this.btnGirls.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirls.Appearance.Options.UseFont = true;
            this.btnGirls.Caption = "Girls";
            this.btnGirls.Id = 3;
            this.btnGirls.LargeGlyph = global::DatingManagement.Properties.Resources.student_2_32;
            this.btnGirls.LargeWidth = 90;
            this.btnGirls.Name = "btnGirls";
            this.btnGirls.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGirls_ItemClick);
            // 
            // btnRegions
            // 
            this.btnRegions.Caption = "Regions";
            this.btnRegions.Id = 4;
            this.btnRegions.LargeGlyph = global::DatingManagement.Properties.Resources.geography_32;
            this.btnRegions.LargeWidth = 80;
            this.btnRegions.Name = "btnRegions";
            this.btnRegions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegions_ItemClick);
            // 
            // btnSchools
            // 
            this.btnSchools.Caption = "Schools";
            this.btnSchools.Id = 5;
            this.btnSchools.LargeGlyph = global::DatingManagement.Properties.Resources.school_32;
            this.btnSchools.LargeWidth = 80;
            this.btnSchools.Name = "btnSchools";
            this.btnSchools.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSchools_ItemClick);
            // 
            // btnCamps
            // 
            this.btnCamps.Caption = "Camps";
            this.btnCamps.Id = 6;
            this.btnCamps.LargeGlyph = global::DatingManagement.Properties.Resources.pre_schools_32;
            this.btnCamps.LargeWidth = 80;
            this.btnCamps.Name = "btnCamps";
            this.btnCamps.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCamps_ItemClick);
            // 
            // btnCountry
            // 
            this.btnCountry.Caption = "Country";
            this.btnCountry.Id = 7;
            this.btnCountry.LargeGlyph = global::DatingManagement.Properties.Resources.world_32;
            this.btnCountry.LargeWidth = 80;
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCountry_ItemClick);
            // 
            // btnSeminarys
            // 
            this.btnSeminarys.Caption = "Seminarys";
            this.btnSeminarys.Id = 9;
            this.btnSeminarys.LargeGlyph = global::DatingManagement.Properties.Resources.college_32;
            this.btnSeminarys.LargeWidth = 90;
            this.btnSeminarys.Name = "btnSeminarys";
            this.btnSeminarys.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSeminarys_ItemClick);
            // 
            // btnYeshivas
            // 
            this.btnYeshivas.Caption = "Yeshivas";
            this.btnYeshivas.Id = 10;
            this.btnYeshivas.LargeGlyph = global::DatingManagement.Properties.Resources.school_fav_32;
            this.btnYeshivas.LargeWidth = 80;
            this.btnYeshivas.Name = "btnYeshivas";
            this.btnYeshivas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeshivas_ItemClick);
            // 
            // btnBaisHamedresh
            // 
            this.btnBaisHamedresh.Caption = "Bais Hamedresh";
            this.btnBaisHamedresh.Id = 11;
            this.btnBaisHamedresh.LargeGlyph = global::DatingManagement.Properties.Resources.house_zoom_32;
            this.btnBaisHamedresh.Name = "btnBaisHamedresh";
            this.btnBaisHamedresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaisHamedresh_ItemClick);
            // 
            // btnMadeShiduchim
            // 
            this.btnMadeShiduchim.Caption = "Made Shiduchim";
            this.btnMadeShiduchim.Id = 12;
            this.btnMadeShiduchim.LargeGlyph = global::DatingManagement.Properties.Resources.classmate_32;
            this.btnMadeShiduchim.Name = "btnMadeShiduchim";
            this.btnMadeShiduchim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMadeShiduchim_ItemClick);
            // 
            // barButtonItemReportDesigner
            // 
            this.barButtonItemReportDesigner.Caption = "Report Designer";
            this.barButtonItemReportDesigner.Id = 13;
            this.barButtonItemReportDesigner.LargeGlyph = global::DatingManagement.Properties.Resources.notepad_32;
            this.barButtonItemReportDesigner.Name = "barButtonItemReportDesigner";
            this.barButtonItemReportDesigner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemReportDesigner_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Shiduchim Management";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFamilies);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBoys);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGirls);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMadeShiduchim);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRegions);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSchools);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnYeshivas);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCamps);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCountry);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSeminarys);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBaisHamedresh);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemReportDesigner);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Others";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 604);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1133, 31);
            // 
            // TabManager
            // 
            this.TabManager.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 635);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Shiduchim Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnFamilies;
        private DevExpress.XtraBars.BarButtonItem btnBoys;
        private DevExpress.XtraBars.BarButtonItem btnGirls;
        private DevExpress.XtraBars.BarButtonItem btnRegions;
        private DevExpress.XtraBars.BarButtonItem btnSchools;
        private DevExpress.XtraBars.BarButtonItem btnCamps;
        private DevExpress.XtraBars.BarButtonItem btnCountry;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager TabManager;
        private DevExpress.XtraBars.BarButtonItem btnSeminarys;
        private DevExpress.XtraBars.BarButtonItem btnYeshivas;
        private DevExpress.XtraBars.BarButtonItem btnBaisHamedresh;
        private DevExpress.XtraBars.BarButtonItem btnMadeShiduchim;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReportDesigner;
    }
}