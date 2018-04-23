Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.rowVisibilityHelper1 = New WindowsApplication1.RowVisibilityHelper()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemButtonEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(493, 510)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
            ' 
            ' repositoryItemButtonEdit1
            ' 
            Me.repositoryItemButtonEdit1.AutoHeight = False
			Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Hide", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
			Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
'			Me.repositoryItemButtonEdit1.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.repositoryItemButtonEdit1_ButtonClick);
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' rowVisibilityHelper1
			' 
			Me.rowVisibilityHelper1.GridView = Me.gridView1
			Me.rowVisibilityHelper1.InvisibleRows.Add(1)
			Me.rowVisibilityHelper1.InvisibleRows.Add(3)
			Me.rowVisibilityHelper1.InvisibleRows.Add(5)
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(12, 528)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Show", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
			Me.spinEdit1.Properties.IsFloatValue = False
			Me.spinEdit1.Properties.Mask.EditMask = "N00"
			Me.spinEdit1.Size = New System.Drawing.Size(225, 20)
			Me.spinEdit1.TabIndex = 1
'			Me.spinEdit1.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.spinEdit1_ButtonClick);
'			Me.spinEdit1.TextChanged += New System.EventHandler(Me.spinEdit1_TextChanged);
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.Location = New System.Drawing.Point(499, 0)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.SelectedObject = Me.rowVisibilityHelper1
			Me.propertyGrid1.Size = New System.Drawing.Size(249, 510)
			Me.propertyGrid1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(760, 577)
			Me.Controls.Add(Me.propertyGrid1)
			Me.Controls.Add(Me.spinEdit1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private rowVisibilityHelper1 As RowVisibilityHelper
		Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private WithEvents repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	End Class
End Namespace

