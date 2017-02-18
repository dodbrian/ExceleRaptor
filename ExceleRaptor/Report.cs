using System;
using System.Collections.Generic;

namespace ExceleRaptor
{
    public class Report
    {
        private ISpreadsheetAdapter _adapter;

        public Report(ISpreadsheetAdapter adapter)
        {
            _adapter = adapter;
        }

        public void Band<T>(string bandName, IEnumerable<T> data, Func<RootBindingContext<T>, BindingContext<T>> ctx)
        {
            ctx(new RootBindingContext<T>(bandName, data));
        }

        public void Render(string pathToTemplate)
        {
            _adapter.SetTemplate(pathToTemplate);
        }
    }
}
