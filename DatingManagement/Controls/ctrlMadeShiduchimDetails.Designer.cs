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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.madeShiduchimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MadeShiduchim_IdSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ItemForMadeShiduchim_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.MonthComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ItemForMonth = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.YearTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForYear = new DevExpress.XtraLayout.LayoutControlItem();
            this.BoysSideLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ItemForBoysSide = new DevExpress.XtraLayout.LayoutControlItem();
            this.AmountBoyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForAmountBoy = new DevExpress.XtraLayout.LayoutControlItem();
            this.GirlsSideLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ItemForGirlsSide = new DevExpress.XtraLayout.LayoutControlItem();
            this.AmountGirlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForAmountGirl = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeShiduchimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MadeShiduchim_IdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMadeShiduchim_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoysSideLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBoysSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBoyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmountBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirlsSideLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGirlsSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountGirlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmountGirl)).BeginInit();
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
            this.dataLayoutControl1.DataSource = this.madeShiduchimBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMadeShiduchim_Id});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(911, 436);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(911, 436);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // madeShiduchimBindingSource
            // 
            this.madeShiduchimBindingSource.DataSource = typeof(DatingManagement.DAL.MadeShiduchim);
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
            // MonthComboBoxEdit
            // 
            this.MonthComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "Month", true));
            this.MonthComboBoxEdit.Location = new System.Drawing.Point(74, 12);
            this.MonthComboBoxEdit.Name = "MonthComboBoxEdit";
            this.MonthComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MonthComboBoxEdit.Size = new System.Drawing.Size(825, 20);
            this.MonthComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.MonthComboBoxEdit.TabIndex = 5;
            // 
            // ItemForMonth
            // 
            this.ItemForMonth.Control = this.MonthComboBoxEdit;
            this.ItemForMonth.CustomizationFormText = "Month";
            this.ItemForMonth.Location = new System.Drawing.Point(0, 0);
            this.ItemForMonth.Name = "ItemForMonth";
            this.ItemForMonth.Size = new System.Drawing.Size(891, 24);
            this.ItemForMonth.Text = "Month";
            this.ItemForMonth.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMonth,
            this.ItemForYear,
            this.ItemForBoysSide,
            this.ItemForAmountBoy,
            this.ItemForGirlsSide,
            this.ItemForAmountGirl});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(891, 416);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // YearTextEdit
            // 
            this.YearTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "Year", true));
            this.YearTextEdit.Location = new System.Drawing.Point(74, 36);
            this.YearTextEdit.Name = "YearTextEdit";
            this.YearTextEdit.Size = new System.Drawing.Size(825, 20);
            this.YearTextEdit.StyleController = this.dataLayoutControl1;
            this.YearTextEdit.TabIndex = 6;
            // 
            // ItemForYear
            // 
            this.ItemForYear.Control = this.YearTextEdit;
            this.ItemForYear.CustomizationFormText = "Year";
            this.ItemForYear.Location = new System.Drawing.Point(0, 24);
            this.ItemForYear.Name = "ItemForYear";
            this.ItemForYear.Size = new System.Drawing.Size(891, 24);
            this.ItemForYear.Text = "Year";
            this.ItemForYear.TextSize = new System.Drawing.Size(58, 13);
            // 
            // BoysSideLookUpEdit
            // 
            this.BoysSideLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "BoysSide", true));
            this.BoysSideLookUpEdit.Location = new System.Drawing.Point(74, 60);
            this.BoysSideLookUpEdit.Name = "BoysSideLookUpEdit";
            this.BoysSideLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BoysSideLookUpEdit.Size = new System.Drawing.Size(825, 20);
            this.BoysSideLookUpEdit.StyleController = this.dataLayoutControl1;
            this.BoysSideLookUpEdit.TabIndex = 7;
            // 
            // ItemForBoysSide
            // 
            this.ItemForBoysSide.Control = this.BoysSideLookUpEdit;
            this.ItemForBoysSide.CustomizationFormText = "Boys Side";
            this.ItemForBoysSide.Location = new System.Drawing.Point(0, 48);
            this.ItemForBoysSide.Name = "ItemForBoysSide";
            this.ItemForBoysSide.Size = new System.Drawing.Size(891, 24);
            this.ItemForBoysSide.Text = "Boys Side";
            this.ItemForBoysSide.TextSize = new System.Drawing.Size(58, 13);
            // 
            // AmountBoyTextEdit
            // 
            this.AmountBoyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "AmountBoy", true));
            this.AmountBoyTextEdit.Location = new System.Drawing.Point(74, 84);
            this.AmountBoyTextEdit.Name = "AmountBoyTextEdit";
            this.AmountBoyTextEdit.Size = new System.Drawing.Size(825, 20);
            this.AmountBoyTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountBoyTextEdit.TabIndex = 8;
            // 
            // ItemForAmountBoy
            // 
            this.ItemForAmountBoy.Control = this.AmountBoyTextEdit;
            this.ItemForAmountBoy.CustomizationFormText = "Amount Boy";
            this.ItemForAmountBoy.Location = new System.Drawing.Point(0, 72);
            this.ItemForAmountBoy.Name = "ItemForAmountBoy";
            this.ItemForAmountBoy.Size = new System.Drawing.Size(891, 24);
            this.ItemForAmountBoy.Text = "Amount Boy";
            this.ItemForAmountBoy.TextSize = new System.Drawing.Size(58, 13);
            // 
            // GirlsSideLookUpEdit
            // 
            this.GirlsSideLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "GirlsSide", true));
            this.GirlsSideLookUpEdit.Location = new System.Drawing.Point(74, 108);
            this.GirlsSideLookUpEdit.Name = "GirlsSideLookUpEdit";
            this.GirlsSideLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GirlsSideLookUpEdit.Size = new System.Drawing.Size(825, 20);
            this.GirlsSideLookUpEdit.StyleController = this.dataLayoutControl1;
            this.GirlsSideLookUpEdit.TabIndex = 9;
            // 
            // ItemForGirlsSide
            // 
            this.ItemForGirlsSide.Control = this.GirlsSideLookUpEdit;
            this.ItemForGirlsSide.CustomizationFormText = "Girls Side";
            this.ItemForGirlsSide.Location = new System.Drawing.Point(0, 96);
            this.ItemForGirlsSide.Name = "ItemForGirlsSide";
            this.ItemForGirlsSide.Size = new System.Drawing.Size(891, 24);
            this.ItemForGirlsSide.Text = "Girls Side";
            this.ItemForGirlsSide.TextSize = new System.Drawing.Size(58, 13);
            // 
            // AmountGirlTextEdit
            // 
            this.AmountGirlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.madeShiduchimBindingSource, "AmountGirl", true));
            this.AmountGirlTextEdit.Location = new System.Drawing.Point(74, 132);
            this.AmountGirlTextEdit.Name = "AmountGirlTextEdit";
            this.AmountGirlTextEdit.Size = new System.Drawing.Size(825, 20);
            this.AmountGirlTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountGirlTextEdit.TabIndex = 10;
            // 
            // ItemForAmountGirl
            // 
            this.ItemForAmountGirl.Control = this.AmountGirlTextEdit;
            this.ItemForAmountGirl.CustomizationFormText = "Amount Girl";
            this.ItemForAmountGirl.Location = new System.Drawing.Point(0, 120);
            this.ItemForAmountGirl.Name = "ItemForAmountGirl";
            this.ItemForAmountGirl.Size = new System.Drawing.Size(891, 296);
            this.ItemForAmountGirl.Text = "Amount Girl";
            this.ItemForAmountGirl.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ctrlMadeShiduchimDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ctrlMadeShiduchimDetails";
            this.Size = new System.Drawing.Size(911, 436);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeShiduchimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MadeShiduchim_IdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMadeShiduchim_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoysSideLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBoysSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBoyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmountBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirlsSideLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGirlsSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountGirlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmountGirl)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMonth;
        private DevExpress.XtraLayout.LayoutControlItem ItemForYear;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBoysSide;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmountBoy;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGirlsSide;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmountGirl;

    }
}