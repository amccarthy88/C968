using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    internal class DataGridViewHelper
    {
        public static bool IsRowSelected(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    return true;
                }
                else
                {
                    selectPartErrorMessage selectPartErrorMessage = new selectPartErrorMessage();
                    selectPartErrorMessage.Show();
                    return false;
                }
            }
            else
            {
                emptyListError emptyListError = new emptyListError();
                emptyListError.Show();
                return false;
            }
        }
    }
}
