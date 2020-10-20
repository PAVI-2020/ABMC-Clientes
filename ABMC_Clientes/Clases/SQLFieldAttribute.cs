using System;

namespace ABMC_Clientes.Clases {
	public class SQLFieldAttribute : System.Attribute {
		public string sqlName;

		public SQLFieldAttribute(string sqlName) {
			this.sqlName = sqlName;
		}
	}

	public class SQLSecondaryFieldAttribute : System.Attribute {
		public string table;
		public string sqlName;

		public SQLSecondaryFieldAttribute(string table, string sqlName) {
			this.table = table;
			this.sqlName = sqlName;
		}
	}

	public class SQLPrimaryKey : System.Attribute {
		public SQLPrimaryKey() { }
	}

	public class SQLDependency : System.Attribute {
		public SQLDependency() { }
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class SQLTableAttribute : System.Attribute {
		public string table;

		public SQLTableAttribute(string table) {
			this.table = table;
		}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class SQLSecondaryTableAttribute : System.Attribute {
		public string table;
		public string joinCondition;

		public SQLSecondaryTableAttribute(string table, string joinCondition) {
			this.table = table;
			this.joinCondition = joinCondition;
		}
	}
}
