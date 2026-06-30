using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_expense_Splitter.Utilities
{
    public static class PerformanceHelper
    {
        // Defer heavy work until after the form is shown:
        // backgroundWork runs on ThreadPool; applyResultOnUi is invoked on the UI thread.
        public static void DeferLoad(Form form, Func<object> backgroundWork, Action<object> applyResultOnUi)
        {
            if (form == null) throw new ArgumentNullException(nameof(form));

            form.Shown += async (s, e) =>
            {
                await Task.Yield(); // give the form a chance to render
                object result = null;
                try
                {
                    result = await Task.Run(backgroundWork);
                }
                catch
                {
                    // handle/log exceptions as needed
                }

                if (applyResultOnUi != null)
                    form.BeginInvoke(new Action(() => applyResultOnUi(result)));
            };
        }
    }
}