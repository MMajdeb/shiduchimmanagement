using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DatingManagement.DAL;
using System.IO;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraReports.UI;
using System.Linq;

namespace DatingManagement.Controls
{
    public partial class ctrlReportDesigner : DevExpress.XtraEditors.XtraForm
    {
        private DatingManagement.Utils.Reports reportName;
        public DatingManagement.Utils.Reports ReportName
        {
            set { reportName = value; }
        }


        public ctrlReportDesigner()
        {
            InitializeComponent();
        }

        public void InitData()
        {
            if (reportName != null)
            {
                XtraReport1 rep = new XtraReport1();

                if (File.Exists(Utils.GetReportPath(reportName)))
                {

                    FileStream strLayout = new FileStream(Utils.GetReportPath(reportName), FileMode.Open);
                    rep.LoadLayout(strLayout);
                }

                rep.DataSource = GetReportDataPreview(reportName);
                xrDesignPanel1.OpenReport(rep);
                barStaticItemReportSelected.Caption = reportName.ToString();

            }

            xrDesignPanel1.AddCommandHandler(new SaveCommandHandler(xrDesignPanel1));
        }



        private void ctrlReportDesigner_Load(object sender, EventArgs e)
        {
            LoadReport(Utils.Reports.FamilyReport);
        }

        private void barButtonItemFamily_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadReport(Utils.Reports.FamilyReport);
        }

        private void barButtonItemBoys_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadReport(Utils.Reports.BoysReport);
        }

        private void barButtonItemGirls_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadReport(Utils.Reports.GirlsReport);
        }

        private void barButtonItemMadeShiduchim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadReport(Utils.Reports.MadeShiduchim);
        }

        private object GetReportDataPreview(DatingManagement.Utils.Reports reportname)
        {
            Object dt = new Object();
            ShiduchimDBDataContext dataclass = new ShiduchimDBDataContext(DataLayer.ConnectionString);

            switch (reportname)
            {
                case Utils.Reports.FamilyReport:
                    dt = dataclass.Families.Take(100).ToList();
                    break;
                case Utils.Reports.BoysReport:
                    dt = dataclass.Boys.Take(100).ToList();
                    break;
                case Utils.Reports.GirlsReport:
                    dt = dataclass.Girls.Take(100).ToList();
                    break;
                case Utils.Reports.MadeShiduchim:
                    dt = dataclass.MadeShiduchims.Take(100).ToList();
                    break;
                default:
                    break;
            }

            return dt;
        }

        public class SaveCommandHandler : ICommandHandler
        {
            XRDesignPanel panel;

            public SaveCommandHandler(XRDesignPanel panel)
            {
                this.panel = panel;
            }

            public virtual void HandleCommand(ReportCommand command, object[] args, ref bool handled)
            {
                if (!CanHandleCommand(command)) return;

                // Save a report.
                //Save();

                // Set handled to true to avoid the standard saving procedure to be called.
                handled = true;
            }

            public virtual bool CanHandleCommand(ReportCommand command)
            {
                // This handler is used for SaveFile, SaveFileAs and Closing commands.
                return command == ReportCommand.SaveFile ||
                    command == ReportCommand.SaveFileAs ||
                    command == ReportCommand.Closing;
            }
        }

        private void LoadReport(DatingManagement.Utils.Reports repName)
        {
            if (xrDesignPanel1.ReportState == ReportState.Changed)
            {
                if (MessageBox.Show("The report has been modified. Do you want to save the report", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    Save();
                }
            }
            reportName = repName;
            InitData();
        }

        private bool Save()
        {
            byte[] Bytes;
            bool hasbeenSaved = false;

            System.IO.MemoryStream str = new System.IO.MemoryStream();

            XtraReport xtra = xrDesignPanel1.Report;
            xtra.SaveLayout(Utils.GetReportPath(reportName));

            xrDesignPanel1.ReportState = ReportState.Opened;

            return hasbeenSaved;
        }

        internal void Close()
        {
            if (xrDesignPanel1.ReportState == ReportState.Changed)
            {
                if (MessageBox.Show("The report has been modified. Do you want to save the report", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    Save();
                }
            }
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }

    }
}