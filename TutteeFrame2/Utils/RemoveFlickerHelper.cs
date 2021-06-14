using System;
using System.Reflection;
using System.Windows.Forms;

namespace TutteeFrame2.Utils
{
    public static class RemoveFlickerHelper
    {
        public static void DoubleBufferedGridView(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
