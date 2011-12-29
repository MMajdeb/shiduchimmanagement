using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTabbedMdi;

namespace DatingManagement
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool isLoading;
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadControl(System.Windows.Forms.Form frm, string sControlName)
        {
            bool finded = false;

            foreach (XtraMdiTabPage page in TabManager.Pages)
            {
                if (page.Text.Equals(sControlName))
                {
                    TabManager.SelectedPage = page;
                    finded = true;
                    return;
                }
            }


            if (!finded)
            {

                isLoading = true;
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Tag = sControlName;
                frm.Text = sControlName;
                frm.Show(); isLoading = false;


            }
        }
        private void btnFamilies_ItemClick(object sender, ItemClickEventArgs e)
        {
            ctrlFamilyList frm = new ctrlFamilyList();

            LoadControl(frm, "Family List");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnFamilies.PerformClick();
        }

        private void btnBoys_ItemClick(object sender, ItemClickEventArgs e)
        {
            ctrlBoysList frm = new ctrlBoysList();
            LoadControl(frm, "Boys List");
        }

        private void btnGirls_ItemClick(object sender, ItemClickEventArgs e)
        {
            ctrlGirlsList frm = new ctrlGirlsList();
            LoadControl(frm, "Girls List");
        }

        private void btnRegions_ItemClick(object sender, ItemClickEventArgs e)
        {
            ctrlRegionList frm = new ctrlRegionList();
            LoadControl(frm, "Regions List");
        }

        private void btnSchools_ItemClick(object sender, ItemClickEventArgs e)
        {
            ctrlSchoolsList frm = new ctrlSchoolsList();
            LoadControl(frm, "Schools List");
        }

        private void btnCamps_ItemClick(object sender, ItemClickEventArgs e)
        {
            ctrlCampsList frm = new ctrlCampsList();
            LoadControl(frm, "Camps List");
        }

        private void btnCountry_ItemClick(object sender, ItemClickEventArgs e)
        {
            ctrlCountryList frm = new ctrlCountryList();
            LoadControl(frm, "Country List");
        }

        private void btnSeminarys_ItemClick(object sender, ItemClickEventArgs e)
        {
            ctrlSeminarysList frm = new ctrlSeminarysList();
            LoadControl(frm, "Seminarys List");
        }

        private void btnYeshivas_ItemClick(object sender, ItemClickEventArgs e)
        {
            ctrlYeshivasList frm = new ctrlYeshivasList();
            LoadControl(frm, "Yeshivas List");
        }

        private void btnBaisHamedresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            ctrlBaisHamedreshList frm = new ctrlBaisHamedreshList();
            LoadControl(frm, "Bais Hamedresh List");
        }

        private void btnMadeShiduchim_ItemClick(object sender, ItemClickEventArgs e)
        {
            ctrlMadeShiduchimList frm = new ctrlMadeShiduchimList();
            LoadControl(frm, "Made Shiduchim List");
        }
    }
}