using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsApplication1;

internal static class Program
{
    [STAThread]
    public static int Main(string[] args)
    {
        ApplicationConfiguration.Initialize();
        bool smoke = args.Length == 2 && args[0] == "--smoke-test";
        if (args.Length != 0 && !(args.Length == 2 && args[0] == "--database") && !smoke)
            return 2;

        string path = args.Length == 2 ? Path.GetFullPath(args[1]) :
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "OnlineResourceBank", "resources.db");
        if (args.Length == 2 && !File.Exists(path))
        {
            if (!smoke) MessageBox.Show("The specified database file does not exist.", "Online Resource Bank");
            return 1;
        }
        try
        {
            using var form = new Form1(path, createIfMissing: args.Length == 0);
            if (smoke)
            {
                form.VerifyOriginalWorkflow();
                return 0;
            }
            Application.Run(form);
            return 0;
        }
        catch (Exception exception)
        {
            if (smoke) Console.Error.WriteLine(exception);
            if (!smoke) MessageBox.Show(exception.Message, "Unable to start Online Resource Bank",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 1;
        }
    }
}
