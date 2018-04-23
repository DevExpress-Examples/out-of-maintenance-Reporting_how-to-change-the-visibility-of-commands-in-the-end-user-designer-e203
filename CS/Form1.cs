using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UserDesigner;
//...

namespace docEUDCommandVisibility {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            // Create an End-User Designer form instance.
            XRDesignFormEx designForm = new XRDesignFormEx();

            // Create a new blank report.
            designForm.DesignPanel.ExecCommand(ReportCommand.NewReport);

            // Hide the "New with Wizard..." item on the File menu and the "Design in Report Wizard..."
            // item in a report's smart tag.
            designForm.DesignPanel.SetCommandVisibility(ReportCommand.NewReportWizard, CommandVisibility.None);
            designForm.DesignPanel.SetCommandVisibility(ReportCommand.VerbReportWizard, CommandVisibility.None);

            // Show the End-User Designer.
            designForm.Show();
        }
    }
}