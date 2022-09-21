namespace pjCasoATM
{
    internal class Cuenta
    {
        private int numeroCuenta;
        private int pin;
        private decimal saldoTotal;

        public Cuenta(int numeroCuenta, int pin, decimal saldoTotal)
        {
            this.NumeroCuenta = numeroCuenta;
            this.pin = pin;
            this.SaldoTotal = saldoTotal;
        }

        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public decimal SaldoTotal { get => saldoTotal; set => saldoTotal = value; }

        internal bool ValidarPIN(int PINUsuario)
        {
            return (PINUsuario == pin);
        }
    }
}