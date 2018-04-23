Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UserDesigner
'...

Namespace docEUDCommandVisibility
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
 Handles button1.Click

            ' Create an End-User Designer form instance.
            Dim designForm As New XRDesignFormEx()

            ' Create a new blank report.
            designForm.DesignPanel.ExecCommand(ReportCommand.NewReport)

            ' Hide the "New with Wizard..." item on the File menu and the "Design in Report Wizard..."
            ' item in a report's smart tag.
            designForm.DesignPanel.SetCommandVisibility(ReportCommand.NewReportWizard, CommandVisibility.None)
            designForm.DesignPanel.SetCommandVisibility(ReportCommand.VerbReportWizard, CommandVisibility.None)

            ' Show the End-User Designer.
            designForm.Show()
        End Sub
    End Class
End Namespace