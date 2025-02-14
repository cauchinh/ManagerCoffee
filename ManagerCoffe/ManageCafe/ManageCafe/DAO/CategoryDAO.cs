﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCafe.DAO
{
	public class CategoryDAO
	{
		private static CategoryDAO instance;


		private CategoryDAO() { }

		public static CategoryDAO Instance
		{
			get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
			private set => CategoryDAO.Instance = value;
		}

		public List<Category> GetListCategory()
		{
			List<Category> list = new List<Category>();

			string query = "SELECT * FROM dbo.FoodCategory";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				Category category = new Category(item);
				list.Add(category);
			}

			return list;
		}
	}
}
