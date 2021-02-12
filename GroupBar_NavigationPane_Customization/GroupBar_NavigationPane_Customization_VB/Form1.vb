Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace groupbartest
	Partial Public Class Form1
		Inherits MetroForm

		Public Sub New()
			InitializeComponent()


		End Sub

		Private Sub GroupBar1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
			Office2007BlueColors.Default.FloatHighlightButtonColor = Color.Pink
		End Sub
	End Class
End Namespace
