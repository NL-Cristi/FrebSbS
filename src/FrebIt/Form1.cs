using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FrebIt
{
    public partial class Form1 : Form
    {
        MyStuff myFunctions = new MyStuff();

        public Form1()
        {
            InitializeComponent();
        }
        private void SingleMenu_Click(object sender, EventArgs e)
        {
            if (this.SingleMenu.Checked)
            {
                this.SingleMenu.Checked = false;
            }
            else
            {
                this.SingleMenu.Checked = true;
                this.SecondMenu.Checked = false;
                this.CompareMenu.Checked = false;
                this.MenuContainerFirst.Visible = true;
                this.MenuContainerFirst.Panel1Collapsed = false;
                this.MenuContainerFirst.Panel2Collapsed = true;
                this.MainContainer.Panel1Collapsed = false;
                this.MainContainer.Panel2Collapsed = true;
                this.FirstWebBrowser.Height = FirstContainer.Panel2.Height - 20;
                this.FirstWebBrowser.Width = FirstContainer.Panel2.Width - 20;

            }
        }

        private void SecondMenu_Click(object sender, EventArgs e)
        {
            if (this.SecondMenu.Checked)
            {
                this.SecondMenu.Checked = false;
            }
            else
            {
                this.SecondMenu.Checked = true;
                this.SingleMenu.Checked = false;
                this.CompareMenu.Checked = false;
                this.MenuContainerFirst.Visible = true;
                this.MenuContainerFirst.Panel1Collapsed = true;
                this.MenuContainerFirst.Panel2Collapsed = false;
                this.MainContainer.Panel1Collapsed = true;
                this.MainContainer.Panel2Collapsed = false;
                this.SecondWebBrowser.Height = FirstContainer.Panel2.Height - 20;
                this.SecondWebBrowser.Width = FirstContainer.Panel2.Width - 20;
            }
        }
        private void CompareMenu_Click(object sender, EventArgs e)
        {
            if (this.CompareMenu.Checked)
            {
                this.CompareMenu.Checked = false;
            }
            else
            {
                this.CompareMenu.Checked = true;
                this.SecondMenu.Checked = false;
                this.SingleMenu.Checked = false;
                this.MenuContainerFirst.Panel1Collapsed = false;
                this.MenuContainerFirst.Panel2Collapsed = false;
                this.MainContainer.Panel1Collapsed = false;
                this.MainContainer.Panel2Collapsed = false;
                this.FirstWebBrowser.Height = FirstContainer.Panel2.Height - 20;
                this.FirstWebBrowser.Width = FirstContainer.Panel2.Width - 20;
                this.SecondWebBrowser.Height = FirstContainer.Panel2.Height - 20;
                this.SecondWebBrowser.Width = FirstContainer.Panel2.Width - 20;
            }
        }

        private void FirstBrowseButton_Click(object sender, EventArgs e)
        {
            this.FirstfolderBrowserDialog.ShowDialog();
            this.FirstFolderTextBox.Text = FirstfolderBrowserDialog.SelectedPath;
        }
        private void SecondBrowseButton_Click(object sender, EventArgs e)
        {
            SecondfolderBrowserDialog.ShowDialog();
            this.SecondFolderTextBox.Text = SecondfolderBrowserDialog.SelectedPath;

        }
        private void FirstScanButton_Click(object sender, EventArgs e)
        {
            if (this.FirstFolderTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please select a valid folder.");
                return;
            }
            this.MainContainer.Show();

            this.FirstDataGridView.Visible = true;
            this.FirstDataGridView.Columns.Clear();
            this.FirstWebBrowser.Height = FirstContainer.Panel2.Height - 20;
            this.FirstWebBrowser.Width = FirstContainer.Panel2.Width - 20;
            try
            {
                myFunctions.PopulateXSL(FirstFolderTextBox.Text.Trim('"'));
                this.FirstDataGridView.DataSource = myFunctions.ToDataTable(myFunctions.GetDataForGrid(FirstFolderTextBox.Text.Trim('"')));
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"No XML files found at destination:\n{ FirstFolderTextBox.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something bad happened. Please report it to cristian@clamsen.com. \nMessage : " + ex.Message + " Stack : \n" + ex.StackTrace);
            }
        }

        private void SecondScanButton_Click(object sender, EventArgs e)
        {
            if (this.SecondFolderTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please select a valid folder.");
                return;
            }
            this.MainContainer.Show();
            this.SecondDataGridView.Visible = true;
            this.SecondDataGridView.Columns.Clear();
            this.SecondWebBrowser.Height = SecondContainer.Panel2.Height - 20;
            this.SecondWebBrowser.Width = SecondContainer.Panel2.Width - 20;
            try
            {
                myFunctions.PopulateXSL(SecondFolderTextBox.Text.Trim('"'));
                this.SecondDataGridView.DataSource = myFunctions.ToDataTable(myFunctions.GetDataForGrid(SecondFolderTextBox.Text.Trim('"')));
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"No XML files found at destination:\n{ SecondFolderTextBox.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something bad happened. Please report it to cristian@clamsen.com. \nMessage : " + ex.Message + " Stack : \n" + ex.StackTrace);
            }
        }

        private void FirstDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!FirstDataGridView.CurrentRow.IsNewRow)
            {
                this.FirstDataGridView.CurrentRow.Selected = true;
                this.FirstContainer.Panel2Collapsed = false;
                this.FirstWebBrowser.Height = FirstContainer.Panel2.Height - 20;
                this.FirstWebBrowser.Width = FirstContainer.Panel2.Width - 20;
                this.FirstWebBrowser.Navigate(((DataGridView)sender).CurrentRow.Cells[7].Value.ToString());
            }
        }

        private void FirstDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.FirstDataGridView.CurrentRow.Selected = true;
            this.FirstContainer.Panel2Collapsed = false;
            this.FirstWebBrowser.Height = FirstContainer.Panel2.Height - 20;
            this.FirstWebBrowser.Width = FirstContainer.Panel2.Width - 20;
            this.FirstWebBrowser.Navigate(((DataGridView)sender).CurrentRow.Cells[7].Value.ToString());

        }

        private void FirstDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.FirstDataGridView.CurrentRow.Selected = true;
            this.SecondContainer.Panel2Collapsed = false;
            this.SecondWebBrowser.Height = SecondContainer.Panel2.Height - 20;
            this.SecondWebBrowser.Width = SecondContainer.Panel2.Width - 20;
            this.FirstWebBrowser.Navigate(((DataGridView)sender).CurrentRow.Cells[7].Value.ToString());

        }

        private void FirstDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var dataa = (Zuby.ADGV.AdvancedDataGridView)sender;
            //var column = dataa.Columns[e.ColumnIndex];
            //var _firstDataTableReportParam = (DataTable)FirstDataGrid.DataSource;
            //DataView dv = _firstDataTableReportParam.DefaultView;
            ////   Sort data
            //dv.Sort = column.DataPropertyName;
            ////   Convert back your sorted DataView to DataTable
            //_firstDataTableReportParam = dv.ToTable();

            //FirstDataGrid.DataSource = _firstDataTableReportParam;

            DataGridViewColumn newColumn = dataa.Columns[e.ColumnIndex];


            DataGridViewColumn oldColumn = dataa.SortedColumn;
            ListSortDirection direction;
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == dataa.Columns[e.ColumnIndex] &&
                    dataa.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // If no column has been selected, display an error dialog  box.
            if (dataa.Columns[e.ColumnIndex] == null)
            {
                MessageBox.Show("Select a single column and try again.",
                    "Error: Invalid Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                dataa.Sort(dataa.Columns[e.ColumnIndex], direction);
                //dataa.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection =
                //    direction == ListSortDirection.Ascending ?
                //    SortOrder.Ascending : SortOrder.Descending;
            }
        }

        private void SecondDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SecondDataGridView.CurrentRow.Selected = true;
            this.SecondContainer.Panel2Collapsed = false;
            this.SecondWebBrowser.Height = SecondContainer.Panel2.Height - 20;
            this.SecondWebBrowser.Width = SecondContainer.Panel2.Width - 20;
            this.SecondWebBrowser.Navigate(((DataGridView)sender).CurrentRow.Cells[7].Value.ToString());

        }

        private void First2022_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.FirstFolderTextBox.Text))
                {
                MessageBox.Show("Please select a valid folder.");
            }
            else
            {
                myFunctions.ReplaceFREB(this.FirstFolderTextBox.Text.Trim('"'), this.First2022.Text);
                this.First2022.Checked = true;
                this.First2019.Checked = false;
                this.First2016.Checked = false;
                this.First2012R2.Checked = false;
                this.First2012.Checked = false;
                this.First2008R2.Checked = false;

            }
        }

        private void First2019_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.FirstFolderTextBox.Text))
            {
                MessageBox.Show("Populate Folder that you want to use!");
            }
            else
            {
                myFunctions.ReplaceFREB(this.FirstFolderTextBox.Text.Trim('"'), this.First2019.Text);
                this.First2022.Checked = false;
                this.First2019.Checked = true;
                this.First2016.Checked = false;
                this.First2012R2.Checked = false;
                this.First2012.Checked = false;
                this.First2008R2.Checked = false;
            }
        }

        private void First2016_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.FirstFolderTextBox.Text))
            {
                MessageBox.Show("Populate Folder that you want to use!");
            }
            else
            {
                myFunctions.ReplaceFREB(this.FirstFolderTextBox.Text.Trim('"'), this.First2016.Text);
                this.First2022.Checked = false;
                this.First2019.Checked = false;
                this.First2016.Checked = true;
                this.First2012R2.Checked = false;
                this.First2012.Checked = false;
                this.First2008R2.Checked = false;
            }
        }

        private void First2012R2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.FirstFolderTextBox.Text))
            {
                MessageBox.Show("Populate Folder that you want to use!");
            }
            else
            {
                myFunctions.ReplaceFREB(this.FirstFolderTextBox.Text.Trim('"'), this.First2012R2.Text);
                this.First2022.Checked = false;
                this.First2019.Checked = false;
                this.First2016.Checked = false;
                this.First2012R2.Checked = true;
                this.First2012.Checked = false;
                this.First2008R2.Checked = false;
            }
        }

        private void First2012_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.FirstFolderTextBox.Text))
            {
                MessageBox.Show("Populate Folder that you want to use!");
            }
            else
            {
                myFunctions.ReplaceFREB(this.FirstFolderTextBox.Text.Trim('"'), this.First2012.Text);
                this.First2022.Checked = false;
                this.First2019.Checked = false;
                this.First2016.Checked = false;
                this.First2012R2.Checked = false;
                this.First2012.Checked = true;
                this.First2008R2.Checked = false;
            }

        }

        private void First2008R2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.FirstFolderTextBox.Text))
            {
                MessageBox.Show("Populate Folder that you want to use!");
            }
            else
            {
                myFunctions.ReplaceFREB(this.FirstFolderTextBox.Text.Trim('"'), this.First2008R2.Text);
                this.First2022.Checked = false;
                this.First2019.Checked = false;
                this.First2016.Checked = false;
                this.First2012R2.Checked = false;
                this.First2012.Checked = false;
                this.First2008R2.Checked = true;
            }
        }

        private void Second2022_Click(object sender, EventArgs e)
        {
                   if(string.IsNullOrWhiteSpace(this.SecondFolderTextBox.Text))
                {
                MessageBox.Show("Populate Folder that you want to use!");
            }
            else
            {
                myFunctions.ReplaceFREB(this.SecondFolderTextBox.Text.Trim('"'), this.Second2022.Text);
                this.Second2022.Checked = true;
                this.Second2019.Checked = false;
                this.Second2016.Checked = false;
                this.Second2012R2.Checked = false;
                this.Second2012.Checked = false;
                this.Second2008R2.Checked = false;
            }
        }

        private void Second2019_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.SecondFolderTextBox.Text))
            {
                MessageBox.Show("Populate Folder that you want to use!");
            }
            else
            {
                myFunctions.ReplaceFREB(this.SecondFolderTextBox.Text.Trim('"'), this.Second2019.Text);
                this.Second2022.Checked = false;
                this.Second2019.Checked = true;
                this.Second2016.Checked = false;
                this.Second2012R2.Checked = false;
                this.Second2012.Checked = false;
                this.Second2008R2.Checked = false;
            }

        }

        private void Second2016_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.SecondFolderTextBox.Text))
            {
                MessageBox.Show("Populate Folder that you want to use!");
            }
            else
            {
                myFunctions.ReplaceFREB(this.SecondFolderTextBox.Text.Trim('"'), this.Second2016.Text);
                this.Second2022.Checked = false;
                this.Second2019.Checked = false;
                this.Second2016.Checked = true;
                this.Second2012R2.Checked = false;
                this.Second2012.Checked = false;
                this.Second2008R2.Checked = false;
            }

        }

        private void Second2012R2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.SecondFolderTextBox.Text))
            {
                MessageBox.Show("Populate Folder that you want to use!");
            }
            else
            {
                myFunctions.ReplaceFREB(this.SecondFolderTextBox.Text.Trim('"'), this.Second2012R2.Text);
                this.Second2022.Checked = false;
                this.Second2019.Checked = false;
                this.Second2016.Checked = false;
                this.Second2012R2.Checked = true;
                this.Second2012.Checked = false;
                this.Second2008R2.Checked = false;
            }
        }

        private void Second2012_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.SecondFolderTextBox.Text))
            {
                MessageBox.Show("Populate Folder that you want to use!");
            }
            else
            {
                myFunctions.ReplaceFREB(this.SecondFolderTextBox.Text.Trim('"'), this.Second2012.Text);
                this.Second2022.Checked = false;
                this.Second2019.Checked = false;
                this.Second2016.Checked = false;
                this.Second2012R2.Checked = false;
                this.Second2012.Checked = true;
                this.Second2008R2.Checked = false;
            }
        }

        private void Second2008R2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.SecondFolderTextBox.Text))
            {
                MessageBox.Show("Populate Folder that you want to use!");
            }
            else
            {
                myFunctions.ReplaceFREB(this.SecondFolderTextBox.Text.Trim('"'), this.Second2008R2.Text);
                this.Second2022.Checked = false;
                this.Second2019.Checked = false;
                this.Second2016.Checked = false;
                this.Second2012R2.Checked = false;
                this.Second2012.Checked = false;
                this.Second2008R2.Checked = true;
            }
        }

        private void HelpMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FrebSbs V1.2 \nFor any feedback/issue please \nreach out to cristian@clamsen.com");

        }
    }
}
