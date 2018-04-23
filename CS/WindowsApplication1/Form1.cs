using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication1
{

    public partial class Form1 : Form
    {
                private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }
        

        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(20);
            gridView1.Columns[0].ColumnEdit = repositoryItemButtonEdit1;
        }

        int GetButtonEditValue()
        {
            return (int)spinEdit1.Value;
        }

        void UpdateButtonEdit()
        {
            EditorButton button = spinEdit1.Properties.Buttons[1];
            button.Enabled = !(spinEdit1.EditValue == null);
            button.Caption = rowVisibilityHelper1.IsRowInvisible(GetButtonEditValue()) ? "Show" : "Hide";

        }

        private void spinEdit1_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonEdit();
        }

        private void spinEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
                rowVisibilityHelper1.ToggleRowVisibility(GetButtonEditValue());
            UpdateButtonEdit();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int focusedRowHandle = gridView1.FocusedRowHandle;
            rowVisibilityHelper1.HideRow(gridView1.GetDataSourceRowIndex(focusedRowHandle));
            gridView1.FocusedRowHandle = focusedRowHandle;
        }
    }
}