﻿using ManageCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCafe.Admin
{
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
			LoadAccountList();
        }

		void LoadAccountList()
		{
			string query = "EXEC dbo.USP_GetAccountByUserName @userName";


			dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "staff" });

		}
	}
}
