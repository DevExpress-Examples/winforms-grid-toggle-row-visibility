Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication1

	Partial Public Class Form1
		Inherits Form
				Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
				End Function


		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(20)
			gridView1.Columns(0).ColumnEdit = repositoryItemButtonEdit1
		End Sub

		Private Function GetButtonEditValue() As Integer
			Return CInt(Fix(spinEdit1.Value))
		End Function

		Private Sub UpdateButtonEdit()
			Dim button As EditorButton = spinEdit1.Properties.Buttons(1)
			button.Enabled = Not(spinEdit1.EditValue Is Nothing)
			If rowVisibilityHelper1.IsRowInvisible(GetButtonEditValue()) Then
				button.Caption = "Show"
			Else
				button.Caption = "Hide"
			End If

		End Sub

		Private Sub spinEdit1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEdit1.TextChanged
			UpdateButtonEdit()
		End Sub

		Private Sub spinEdit1_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs) Handles spinEdit1.ButtonClick
			If e.Button.Index = 1 Then
				rowVisibilityHelper1.ToggleRowVisibility(GetButtonEditValue())
			End If
			UpdateButtonEdit()
		End Sub

        Private Sub repositoryItemButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs) Handles repositoryItemButtonEdit1.ButtonClick
            Dim focusedRowHandle As Integer = gridView1.FocusedRowHandle
            rowVisibilityHelper1.HideRow(gridView1.GetDataSourceRowIndex(focusedRowHandle))
            gridView1.FocusedRowHandle = focusedRowHandle
        End Sub
    End Class
End Namespace