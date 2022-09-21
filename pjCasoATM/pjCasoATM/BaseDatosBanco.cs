namespace pjCasoATM
{
    internal class BaseDatosBanco
    {
        private Cuenta[] cuentas;

        public BaseDatosBanco()
        {
            cuentas = new Cuenta[2];
            cuentas[0] = new Cuenta(12345, 4321, 1000.00M);
            cuentas[1] = new Cuenta(98765, 4321, 1000.00M);
        }

        internal bool AutenticarUsuario(int numeroCuenta, int pin)
        {
            Cuenta cuentaUsuario = ObtenerCuenta(numeroCuenta);

            if (cuentaUsuario != null)
                return cuentaUsuario.ValidarPIN(pin);
            else
                return false;
        }

        private Cuenta ObtenerCuenta(int numeroCuenta)
        {
            foreach(Cuenta cuenta in cuentas)
            {
                if(cuenta.NumeroCuenta == numeroCuenta)
                    return cuenta;
            }

            return null;
        }
    }
}