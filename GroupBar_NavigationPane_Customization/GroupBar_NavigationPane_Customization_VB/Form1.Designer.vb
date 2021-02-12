Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace groupbartest
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MetroForm))
			Me.groupBar1 = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox()
			Me.groupBarItem1 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem2 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem3 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBar1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' groupBar1
			' 
			Me.groupBar1.AllowCollapse = True
			Me.groupBar1.AllowDrop = True
			Me.groupBar1.AnimatedSelection = False
			Me.groupBar1.BeforeTouchSize = New System.Drawing.Size(293, 619)
			Me.groupBar1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(99)))), (CInt((CByte(146)))), (CInt((CByte(206)))))
			Me.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.groupBar1.Controls.Add(Me.checkedListBox1)
			Me.groupBar1.Dock = System.Windows.Forms.DockStyle.Left
			Me.groupBar1.ExpandButtonToolTip = Nothing
			Me.groupBar1.FlatLook = True
			Me.groupBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.groupBar1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(33)))), (CInt((CByte(77)))), (CInt((CByte(140)))))
			Me.groupBar1.GroupBarDropDownToolTip = Nothing
			Me.groupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.groupBarItem1, Me.groupBarItem2, Me.groupBarItem3})
			Me.groupBar1.HeaderBackColor = System.Drawing.SystemColors.ControlDark
			Me.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(65)))), (CInt((CByte(140)))))
			Me.groupBar1.IndexOnVisibleItems = True
			Me.groupBar1.Location = New System.Drawing.Point(0, 0)
			Me.groupBar1.Margin = New System.Windows.Forms.Padding(4)
			Me.groupBar1.MinimizeButtonToolTip = Nothing
			Me.groupBar1.Name = "groupBar1"
			Me.groupBar1.NavigationPaneTooltip = Nothing
			Me.groupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.groupBar1.SelectedItem = 2
			Me.groupBar1.Size = New System.Drawing.Size(293, 619)
			Me.groupBar1.SmartSizeBox = False
			Me.groupBar1.Splittercolor = System.Drawing.SystemColors.ControlDark
			Me.groupBar1.StackedMode = True
			Me.groupBar1.TabIndex = 0
			Me.groupBar1.Text = "groupBar1"
			Me.groupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.groupBar1.ThemeName = "Office2007"
			Me.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			AddHandler Me.groupBar1.MouseClick, AddressOf GroupBar1_MouseClick


			' 
			' checkedListBox1
			' 
			Me.checkedListBox1.FormattingEnabled = True
			Me.checkedListBox1.Location = New System.Drawing.Point(1, 33)
			Me.checkedListBox1.Name = "checkedListBox1"
			Me.checkedListBox1.Size = New System.Drawing.Size(291, 454)
			Me.checkedListBox1.TabIndex = 0
			' 
			' groupBarItem1
			' 
			Me.groupBarItem1.Client = Nothing
			Me.groupBarItem1.Text = "GroupBarItem0"
			' 
			' groupBarItem2
			' 
			Me.groupBarItem2.Client = Nothing
			Me.groupBarItem2.Text = "GroupBarItem1"
			' 
			' groupBarItem3
			' 
			Me.groupBarItem3.Client = Me.checkedListBox1
			Me.groupBarItem3.Text = "GroupBarItem2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(312, 619)
			Me.Controls.Add(Me.groupBar1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "GroupBarSample"
			Me.CaptionBarColor = Color.FromArgb(250,17,158,218)
			Me.Font = New Font("Calibri",12)
			CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBar1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub



		#End Region

		Private groupBar1 As Syncfusion.Windows.Forms.Tools.GroupBar
		Private groupBarItem1 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem2 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem3 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private checkedListBox1 As CheckedListBox
	End Class
End Namespace

