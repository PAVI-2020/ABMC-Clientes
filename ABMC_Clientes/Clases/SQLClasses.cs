namespace ABMC_Clientes.Clases {
	public class SQLBit {
		bool value;

        public static bool operator ==(SQLBit a, bool b) {
            if (a == null) {
                return false;
            }

            return a.value == b;
        }

        public static bool operator !=(SQLBit a, bool b) {
            return !(a == b);
        }

        public override string ToString() {
			return value ? "1" : "0";
		}
	}
}
