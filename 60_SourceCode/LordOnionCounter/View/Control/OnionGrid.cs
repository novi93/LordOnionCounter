using System.Drawing;
using System.Windows.Forms;

namespace LOC.View
{
    public class OnionGrid : DataGridViewSummary.DataGridViewSummary
    {
        public OnionGrid() : base()
        {
            //this.CellFormatting += new DataGridViewCellFormattingEventHandler(this.OnionGrid_CellFormatting);
            this.DataError += new DataGridViewDataErrorEventHandler(this.OnionGrid_DataError);
            this.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.OnionGrid_DataBindingComplete);

        }

        private void OnionGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in Columns)
            {
                if (column.ReadOnly == false && column.ValueType != typeof(bool))
                {
                    column.DefaultCellStyle.BackColor = Color.LemonChiffon;
                }


                if (column.ValueType == typeof(int))
                {
                    column.DefaultCellStyle.Format = "#,##0";
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                else
                if (column.ValueType == typeof(decimal))
                {
                    column.DefaultCellStyle.Format = "#,##0.0";
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void OnionGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

    }
}
