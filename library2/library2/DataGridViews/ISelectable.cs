﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    interface ISelectable
    {
        void SelectRows(DataGridView dgv);
    }
}