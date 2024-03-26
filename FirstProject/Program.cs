using FirstProject.model;

namespace FirstProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            ExpressionParser test = new ExpressionParser("(2+3)*5.1");
            MessageBox.Show(String.Join("", test.test.ToArray()));
        }
    }
}