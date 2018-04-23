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

Namespace WindowsApplication1
	Public Class RowVisibilityHelper
		Inherits Component
		Private _GridView As GridView
		Public Property GridView() As GridView
			Get
				Return _GridView
			End Get
			Set(ByVal value As GridView)
				UnSubscribeEvents()
				_GridView = value
				SubscribeEvents()
			End Set
		End Property


		Private _InvisibleRows As List(Of Integer)
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Property InvisibleRows() As List(Of Integer)
			Get
				If _InvisibleRows Is Nothing Then
					_InvisibleRows = New List(Of Integer)()
				End If
				Return _InvisibleRows
			End Get
			Set(ByVal value As List(Of Integer))
				_InvisibleRows = value
			End Set
		End Property

		Private Sub UnSubscribeEvents()
			If GridView IsNot Nothing Then
				RemoveHandler GridView.CustomRowFilter, AddressOf GridView_CustomRowFilter
			End If
		End Sub

		Private Sub SubscribeEvents()
			AddHandler GridView.CustomRowFilter, AddressOf GridView_CustomRowFilter
		End Sub

		Public Function IsRowInvisible(ByVal dataSourceRowIndex As Integer) As Boolean
			Return InvisibleRows.Contains(dataSourceRowIndex)
		End Function

		Private Sub GridView_CustomRowFilter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs)
			If IsRowInvisible(e.ListSourceRow) Then
				e.Visible = False
				e.Handled = True
			End If
		End Sub

		Public Sub HideRow(ByVal dataSourceRowIndex As Integer)
			If (Not IsRowInvisible(dataSourceRowIndex)) Then
				InvisibleRows.Add(dataSourceRowIndex)
			End If
			GridView.RefreshData()
		End Sub

		Public Sub ShowRow(ByVal dataSourceRowIndex As Integer)
			If IsRowInvisible(dataSourceRowIndex) Then
				InvisibleRows.Remove(dataSourceRowIndex)
			End If
			GridView.RefreshData()
		End Sub

		Public Sub ToggleRowVisibility(ByVal dataSourceRowIndex As Integer)
			If IsRowInvisible(dataSourceRowIndex) Then
				ShowRow(dataSourceRowIndex)
			Else
				HideRow(dataSourceRowIndex)
			End If
		End Sub

	End Class
End Namespace
