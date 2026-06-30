using System.Reflection;
using System.Windows.Forms;

namespace Travel_expense_Splitter
{
    public static class ControlExtensions
    {
        // Enables the protected DoubleBuffered property for controls that don't expose it.
        public static void SetDoubleBuffered(this Control control)
        {
            if (control == null) return;
            typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                ?.SetValue(control, true, null);
        }
    }
}