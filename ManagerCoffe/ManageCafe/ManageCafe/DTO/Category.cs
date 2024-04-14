﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCafe.DAO
{
	public class Category
	{
		public Category(int id, string _name) 
		{
			this.iD = id;
			this.name = _name;
		}	

		public Category(DataRow row) 
		{
			this.iD = (int)row["ID"];
			this.name = row["Name"].ToString();
		}

		private string name;

		private int iD;

		public int ID { get => iD; set => iD = value; }
		public string Name { get => name; set => name = value; }
	}
}
