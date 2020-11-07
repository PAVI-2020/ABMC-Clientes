using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public class UIConverter {
		
	}

	public class MaterialButton : Button {
		private Color regularColor = Color.White;
		private Color disabledColor = Color.Black;

		public new bool Enabled {
			get { return base.Enabled; }
			set {
				base.Enabled = value;
				this.BackColor = Enabled ? regularColor : disabledColor;
			}
		}
		[Category("Appearance"), Description("Solid color when disabled.")]
		public Color DisabledColor { get => disabledColor; set { disabledColor = value; Invalidate(); } }
		[Category("Appearance"), Description("Solid color when enabled.")]
		public Color RegularColor { get => regularColor; set { regularColor = value; Invalidate(); } }
	}
}
