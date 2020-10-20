using System.Collections.Generic;
using System.Windows.Forms;

namespace ABMC_Clientes.Business {
	public class Verificador {

		string errorHeader;
		string errorFooter;
		List<VerifyField> fields;

		public Verificador() {
			fields = new List<VerifyField>();
			this.errorHeader = "Complete los siguientes campos:";
			this.errorFooter = "";
		}

		public void Agregar(string name, Control desde) {
			fields.Add(new VerifyField(name, desde));
		}

		public bool Verificar() {
			bool res = true;
			List<string> errorFields = new List<string>();

			foreach (VerifyField field in fields)
				if (
					(field.desde.GetType() == typeof(TextBox) && field.desde.Text == "") ||
					(field.desde.GetType() == typeof(ComboBox) && ((ComboBox)field.desde).SelectedIndex == -1)
					) {
					res = false;
					errorFields.Add(field.name);
				}

			string error = errorHeader;
			foreach (string e in errorFields)
				error += "\n" + e;
			error += errorFooter;

			if (!res)
				MessageBox.Show(error, "Error de verificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

			return res;
		}
	}

	class VerifyField {
		public string name;
		public Control desde;

		public VerifyField(string name, Control desde) {
			this.name = name;
			this.desde = desde;
		}
	}
}
