namespace DatingManagement
{
    partial class ctrlMadeShiduchimDetails
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.MadeShiduchim_IdSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.MonthComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.YearTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BoysSideLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.AmountBoyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.GirlsSideLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.AmountGirlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForMadeShiduchim_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.madeShiduchimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemForMonth = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForYear = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBoysSide = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmountBoy = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGirlsSide = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmountGirl = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShiduchimDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ShiduchimDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MadeShiduchim_IdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoysSideLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBoyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirlsSideLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountGirlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMadeShiduchim_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeShiduchimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBoysSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmountBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGirlsSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmountGirl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShiduchimDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShiduchimDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShiduchimDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.MadeShiduchim_IdSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.MonthComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.YearTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BoysSideLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.AmountBoyTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GirlsSideLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.AmountGirlTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ShiduchimDateDateEdit);
            this.dataLayoutControl1.DataSource = this.madeShiduchimBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMadeShiduchim_Id});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(666, 436);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // MadeShiduchim_IdSpinEdit
            // 
            this.MadeShiduchim_IdSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "MadeShiduchim_Id", true));
            this.MadeShiduchim_IdSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.MadeShiduchim_IdSpinEdit.Location = new System.Drawing.Point(0, 0);
            this.MadeShiduchim_IdSpinEdit.Name = "MadeShiduchim_IdSpinEdit";
            this.MadeShiduchim_IdSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.MadeShiduchim_IdSpinEdit.Size = new System.Drawing.Size(0, 20);
            this.MadeShiduchim_IdSpinEdit.StyleController = this.dataLayoutControl1;
            this.MadeShiduchim_IdSpinEdit.TabIndex = 4;
            // 
            // MonthComboBoxEdit
            // 
            this.MonthComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "Month", true));
            this.MonthComboBoxEdit.Location = new System.Drawing.Point(89, 12);
            this.MonthComboBoxEdit.Name = "MonthComboBoxEdit";
            this.MonthComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MonthComboBoxEdit.Size = new System.Drawing.Size(295, 20);
            this.MonthComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.MonthComboBoxEdit.TabIndex = 5;
            // 
            // YearTextEdit
            // 
            this.YearTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "Year", true));
            this.YearTextEdit.Location = new System.Drawing.Point(89, 36);
            this.YearTextEdit.Name = "YearTextEdit";
            this.YearTextEdit.Size = new System.Drawing.Size(295, 20);
            this.YearTextEdit.StyleController = this.dataLayoutControl1;
            this.YearTextEdit.TabIndex = 6;
            // 
            // BoysSideLookUpEdit
            // 
            this.BoysSideLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "BoysSide", true));
            this.BoysSideLookUpEdit.Location = new System.Drawing.Point(89, 60);
            this.BoysSideLookUpEdit.Name = "BoysSideLookUpEdit";
            this.BoysSideLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BoysSideLookUpEdit.Size = new System.Drawing.Size(295, 20);
            this.BoysSideLookUpEdit.StyleController = this.dataLayoutControl1;
            this.BoysSideLookUpEdit.TabIndex = 7;
            // 
            // AmountBoyTextEdit
            // 
            this.AmountBoyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "AmountBoy", true));
            this.AmountBoyTextEdit.Location = new System.Drawing.Point(89, 84);
            this.AmountBoyTextEdit.Name = "AmountBoyTextEdit";
            this.AmountBoyTextEdit.Size = new System.Drawing.Size(295, 20);
            this.AmountBoyTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountBoyTextEdit.TabIndex = 8;
            // 
            // GirlsSideLookUpEdit
            // 
            this.GirlsSideLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "GirlsSide", true));
            this.GirlsSideLookUpEdit.Location = new System.Drawing.Point(89, 108);
            this.GirlsSideLookUpEdit.Name = "GirlsSideLookUpEdit";
            this.GirlsSideLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GirlsSideLookUpEdit.Size = new System.Drawing.Size(295, 20);
            this.GirlsSideLookUpEdit.StyleController = this.dataLayoutControl1;
            this.GirlsSideLookUpEdit.TabIndex = 9;
            // 
            // AmountGirlTextEdit
            // 
            this.AmountGirlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "AmountGirl", true));
            this.AmountGirlTextEdit.Location = new System.Drawing.Point(89, 132);
            this.AmountGirlTextEdit.Name = "AmountGirlTextEdit";
            this.AmountGirlTextEdit.Size = new System.Drawing.Size(295, 20);
            this.AmountGirlTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountGirlTextEdit.TabIndex = 10;
            // 
            // ItemForMadeShiduchim_Id
            // 
            this.ItemForMadeShiduchim_Id.Control = this.MadeShiduchim_IdSpinEdit;
            this.ItemForMadeShiduchim_Id.CustomizationFormText = "Made Shiduchim_Id";
            this.ItemForMadeShiduchim_Id.Location = new System.Drawing.Point(0, 0);
            this.ItemForMadeShiduchim_Id.Name = "ItemForMadeShiduchim_Id";
            this.ItemForMadeShiduchim_Id.Size = new System.Drawing.Size(0, 0);
            this.ItemForMadeShiduchim_Id.Text = "Made Shiduchim_Id";
            this.ItemForMadeShiduchim_Id.TextSize = new System.Drawing.Size(50, 20);
            this.ItemForMadeShiduchim_Id.TextToControlDistance = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(666, 436);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AllowDrawBackground = false;
            this.layoutControlGroup3.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.ItemForShiduchimDate,
            this.ItemForAmountGirl,
            this.ItemForGirlsSide,
            this.ItemForAmountBoy,
            this.ItemForBoysSide,
            this.ItemForYear,
            this.ItemForMonth});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "item0";
            this.layoutControlGroup3.Size = new System.Drawing.Size(646, 416);
            this.layoutControlGroup3.Text = "item0";
            // 
            // madeShiduchimBindingSource
            // 
            this.madeShiduchimBindingSource.DataSource = typeof(DatingManagement.DAL.MadeShiduchim);
            // 
            // ItemForMonth
            // 
            this.ItemForMonth.Control = this.MonthComboBoxEdit;
            this.ItemForMonth.CustomizationFormText = "Month";
            this.ItemForMonth.Location = new System.Drawing.Point(0, 0);
            this.ItemForMonth.Name = "ItemForMonth";
            this.ItemForMonth.Size = new System.Drawing.Size(376, 24);
            this.ItemForMonth.Text = "Month";
            this.ItemForMonth.TextSize = new System.Drawing.Size(73, 13);
            // 
            // ItemForYear
            // 
            this.ItemForYear.Control = this.YearTextEdit;
            this.ItemForYear.CustomizationFormText = "Year";
            this.ItemForYear.Location = new System.Drawing.Point(0, 24);
            this.ItemForYear.Name = "ItemForYear";
            this.ItemForYear.Size = new System.Drawing.Size(376, 24);
            this.ItemForYear.Text = "Year";
            this.ItemForYear.TextSize = new System.Drawing.Size(73, 13);
            // 
            // ItemForBoysSide
            // 
            this.ItemForBoysSide.Control = this.BoysSideLookUpEdit;
            this.ItemForBoysSide.CustomizationFormText = "Boys Side";
            this.ItemForBoysSide.Location = new System.Drawing.Point(0, 48);
            this.ItemForBoysSide.Name = "ItemForBoysSide";
            this.ItemForBoysSide.Size = new System.Drawing.Size(376, 24);
            this.ItemForBoysSide.Text = "Boys Side";
            this.ItemForBoysSide.TextSize = new System.Drawing.Size(73, 13);
            // 
            // ItemForAmountBoy
            // 
            this.ItemForAmountBoy.Control = this.AmountBoyTextEdit;
            this.ItemForAmountBoy.CustomizationFormText = "Amount Boy";
            this.ItemForAmountBoy.Location = new System.Drawing.Point(0, 72);
            this.ItemForAmountBoy.Name = "ItemForAmountBoy";
            this.ItemForAmountBoy.Size = new System.Drawing.Size(376, 24);
            this.ItemForAmountBoy.Text = "Amount Boy";
            this.ItemForAmountBoy.TextSize = new System.Drawing.Size(73, 13);
            // 
            // ItemForGirlsSide
            // 
            this.ItemForGirlsSide.Control = this.GirlsSideLookUpEdit;
            this.ItemForGirlsSide.CustomizationFormText = "Girls Side";
            this.ItemForGirlsSide.Location = new System.Drawing.Point(0, 96);
            this.ItemForGirlsSide.Name = "ItemForGirlsSide";
            this.ItemForGirlsSide.Size = new System.Drawing.Size(376, 24);
            this.ItemForGirlsSide.Text = "Girls Side";
            this.ItemForGirlsSide.TextSize = new System.Drawing.Size(73, 13);
            // 
            // ItemForAmountGirl
            // 
            this.ItemForAmountGirl.Control = this.AmountGirlTextEdit;
            this.ItemForAmountGirl.CustomizationFormText = "Amount Girl";
            this.ItemForAmountGirl.Location = new System.Drawing.Point(0, 120);
            this.ItemForAmountGirl.Name = "ItemForAmountGirl";
            this.ItemForAmountGirl.Size = new System.Drawing.Size(376, 24);
            this.ItemForAmountGirl.Text = "Amount Girl";
            this.ItemForAmountGirl.TextSize = new System.Drawing.Size(73, 13);
            // 
            // ItemForShiduchimDate
            // 
            this.ItemForShiduchimDate.Control = this.ShiduchimDateDateEdit;
            this.ItemForShiduchimDate.CustomizationFormText = "Shiduchim Date";
            this.ItemForShiduchimDate.Location = new System.Drawing.Point(0, 144);
            this.ItemForShiduchimDate.Name = "ItemForShiduchimDate";
            this.ItemForShiduchimDate.Size = new System.Drawing.Size(376, 272);
            this.ItemForShiduchimDate.Text = "Shiduchim Date";
            this.ItemForShiduchimDate.TextSize = new System.Drawing.Size(73, 13);
            // 
            // ShiduchimDateDateEdit
            // 
            this.ShiduchimDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "ShiduchimDate", true));
            this.ShiduchimDateDateEdit.EditValue = null;
            this.ShiduchimDateDateEdit.Location = new System.Drawing.Point(89, 156);
            this.ShiduchimDateDateEdit.Name = "ShiduchimDateDateEdit";
            this.ShiduchimDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ShiduchimDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ShiduchimDateDateEdit.Size = new System.Drawing.Size(295, 20);
            this.ShiduchimDateDateEdit.StyleController = this.dataLayoutControl1;
            this.ShiduchimDateDateEdit.TabIndex = 12;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(376, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(270, 416);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ctrlMadeShiduchimDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ctrlMadeShiduchimDetails";
            this.Size = new System.Drawing.Size(666, 436);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MadeShiduchim_IdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoysSideLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBoyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirlsSideLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountGirlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMadeShiduchim_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeShiduchimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBoysSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmountBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGirlsSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmountGirl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShiduchimDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShiduchimDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShiduchimDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SpinEdit MadeShiduchim_IdSpinEdit;
        private System.Windows.Forms.BindingSource madeShiduchimBindingSource;
        private DevExpress.XtraEditors.ComboBoxEdit MonthComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit YearTextEdit;
        private DevExpress.XtraEditors.LookUpEdit BoysSideLookUpEdit;
        private DevExpress.XtraEditors.TextEdit AmountBoyTextEdit;
        private DevExpress.XtraEditors.LookUpEdit GirlsSideLookUpEdit;
        private DevExpress.XtraEditors.TextEdit AmountGirlTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMadeShiduchim_Id;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMonth;
        private DevExpress.XtraLayout.LayoutControlItem ItemForYear;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBoysSide;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmountBoy;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGirlsSide;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmountGirl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShiduchimDate;
        private DevExpress.XtraEditors.DateEdit ShiduchimDateDateEdit;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;

    }
}