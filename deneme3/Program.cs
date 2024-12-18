using System;
using System.Windows.Forms;

namespace deneme3
{
    static class Program
    {
        // Uygulamanın başlangıç noktası
        [STAThread]
        static void Main()
        {
            // Uygulama başlatıldığında, Form1'i aç
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

