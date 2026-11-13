namespace ProjetoLeiLucasTelas
{
    internal static class Program
    {
        // instanciando Forms
        public static TelaInicio? Inicio;
        public static Form2? Emergencia;
        public static Form3? Ajuda;
        public static telaInforLei? InfoLei;
        public static FormTreinamento? Treinamento;
        public static FormRelatorios? Relatorios;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Inicio = new TelaInicio();
            Emergencia = new Form2();
            Ajuda = new Form3();
            InfoLei = new telaInforLei();
            Treinamento = new FormTreinamento();
            Relatorios = new FormRelatorios();

            _ = Inicio.Handle;
            _ = Emergencia.Handle;
            _ = Ajuda.Handle;
            _ = InfoLei.Handle;
            _ = Treinamento.Handle;
            _ = Relatorios.Handle;

            Application.Run(Inicio);
        }
    }
}