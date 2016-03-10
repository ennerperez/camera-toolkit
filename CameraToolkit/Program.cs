using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Toolkit
{
    static class Program
    {

        internal static FilterInfoCollection devices;
        internal static List<string> activeDevices;

        internal static List<string> imageFiles = new List<string>(new string[] { ".jpg", ".jpeg", ".jpe", ".jfif", ".png", ".gif" });

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            activeDevices = new List<string>();
            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormMain());
        }

        internal static Dictionary<string, string> getDevices()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            if (devices.Count > 0)
            {
                for (int i = 0; i < devices.Count; i++)
                {
                    result.Add(devices[i].MonikerString, devices[i].Name.ToString());
                }
            }

            return result;
        }

    }
}
