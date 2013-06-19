using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WPDHelper
{
    public partial class Form1
    {
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DGV = GetSenderDataGridView(this.Controls);
            CutCells(DGV);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DGV = GetSenderDataGridView(this.Controls);
            if (DGV != null)
            {
                CopyToClipboard(DGV);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DGV = GetSenderDataGridView(this.Controls);
            if (DGV != null)
            {
                PasteClipboardValue(DGV);
            }
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var DGV = GetSenderDataGridView(this.Controls);
            if(DGV != null)
            {
                if (DGV.SelectedCells.Count > 0)
                {
                    DGV.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void DGV_KeyDown(object sender, KeyEventArgs e)
        {
            var DGV = GetSenderDataGridView(this.Controls);
            if(DGV != null)
            {
                try
                {
                    if (e.Modifiers == Keys.Control)
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.C:
                                CopyToClipboard(DGV);
                                break;

                            case Keys.V:
                                PasteClipboardValue(DGV);
                                break;
                            case Keys.X:
                                CutCells(DGV);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Copy/paste operation failed. " + ex.Message, "Copy/Paste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CutCells(DataGridView DGV)
        {
            CopyToClipboard(DGV);
            foreach (DataGridViewCell dgvCell in DGV.SelectedCells)
            {
                dgvCell.Value = string.Empty;
            }

            #region cutting cells from DataGridView
            var rowIndex = -1;
            var colIndex = -1;
            foreach (DataGridViewCell dgvCell in DGV.SelectedCells)
            {
                if (rowIndex == -1)
                {
                    rowIndex = dgvCell.RowIndex;
                    colIndex = 0;
                }
                else
                {
                    if (rowIndex == dgvCell.RowIndex)
                    {
                        colIndex++;
                    }
                }
                if (rowIndex != dgvCell.RowIndex && colIndex == DGV.Columns.Count - 1)
                {
                    //if DataGridView.DataSource == DataTable
                    if (DGV.DataSource is DataTable)
                    {
                        var table = (DataTable)DGV.DataSource;
                        table.Rows.RemoveAt(rowIndex);
                    }
                    rowIndex = dgvCell.RowIndex;
                    colIndex = 0;
                }
            }
            //last cutting row
            if (colIndex == DGV.Columns.Count - 1)
            {
                //if DataGridView.DataSource == DataTable
                if (DGV.DataSource is DataTable)
                {
                    var table = (DataTable)DGV.DataSource;
                    table.Rows.RemoveAt(rowIndex);
                }
            }
            #endregion
            
        }

        private void CopyToClipboard(DataGridView DGV)
        {
            DataObject dataObj = DGV.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void PasteClipboardValue(DataGridView DGV)
        {
            if (DGV.SelectedCells.Count == 0)
            {
                return;
            }

            DataGridViewCell startCell = GetStartCell(DGV);
            Dictionary<int, Dictionary<int, string>> cbValue = ClipBoardValues(Clipboard.GetText());

            int iRowIndex = startCell.RowIndex;
            foreach (int rowKey in cbValue.Keys)
            {
                int iColIndex = startCell.ColumnIndex;
                //foreach (int cellKey in cbValue[rowKey].Keys)
                for (int cellKey = 0; cellKey < cbValue[rowKey].Count; cellKey++ )
                {
                    if (iColIndex <= DGV.Columns.Count - 1 && iRowIndex <= DGV.Rows.Count)
                    {
                        var table = (DataTable)DGV.DataSource;
                        if (iRowIndex == table.Rows.Count)
                        {
                            table.Rows.Add();
                        }
                        var str = cbValue[rowKey][cellKey].Replace("\r", "");
                        if (str == "•" && cellKey + 1 <= cbValue[rowKey].Count)
                        {
                            cellKey++;
                        }
                        table.Rows[iRowIndex][iColIndex] = cbValue[rowKey][cellKey].Replace("\r", "");

                        //было
                        //if (iRowIndex == DGV.Rows.Count - 1)
                        //{
                        //    var table = (DataTable)DGV.DataSource;
                        //    table.Rows.Add();
                        //}
                        //DataGridViewCell cell = DGV[iColIndex, iRowIndex];
                        //cell.Value = cbValue[rowKey][cellKey].Replace("\r", "");
                    }
                    iColIndex++;
                }
                iRowIndex++;
            }
            var dif = DGV.Rows.Count - ((DataTable)DGV.DataSource).Rows.Count;
            if (dif > 1)
            {
                for (var i = 0; i < dif - 1; i++)
                {
                    DGV.Rows.RemoveAt(DGV.Rows.Count - 2);
                }
            }
        }

        private DataGridViewCell GetStartCell(DataGridView DGV)
        {
            if (DGV.SelectedCells.Count == 0)
                return null;

            int rowIndex = DGV.Rows.Count - 1;
            int colIndex = DGV.Columns.Count - 1;

            foreach (DataGridViewCell dgvCell in DGV.SelectedCells)
            {
                if (dgvCell.RowIndex < rowIndex)
                    rowIndex = dgvCell.RowIndex;
                if (dgvCell.ColumnIndex < colIndex)
                    colIndex = dgvCell.ColumnIndex;
            }

            return DGV[colIndex, rowIndex];
        }

        private Dictionary<int, Dictionary<int, string>> ClipBoardValues(string clipboardValue)
        {
            Dictionary<int, Dictionary<int, string>> copyValues = new Dictionary<int, Dictionary<int, string>>();

            String[] lines = clipboardValue.Split('\n');

            for (int i = 0; i <= lines.Length - 1; i++)
            {
                copyValues[i] = new Dictionary<int, string>();
                String[] lineContent = lines[i].Split('\t');

                //if an empty cell value copied, then set the dictionay with an empty string
                //else Set value to dictionary
                if (lineContent.Length == 0)
                    copyValues[i][0] = string.Empty;
                else
                {
                    for (int j = 0; j <= lineContent.Length - 1; j++)
                        copyValues[i][j] = lineContent[j];
                }
            }
            return copyValues;
        }

        private DataGridView GetSenderDataGridView(Control.ControlCollection controls)
        {
            DataGridView result = null;
            foreach (Control c in controls)
            {
                if(c.ContainsFocus)
                {
                    if (c.Focused && c.GetType().ToString() == "System.Windows.Forms.DataGridView")
                    {
                        return result = (DataGridView)c;
                    }
                    else
                    {
                        result = GetSenderDataGridView(c.Controls);
                    }
                }
                else
                {
                    
                }
            }
            return result;
        }
    }
}