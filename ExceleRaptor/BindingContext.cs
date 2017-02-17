using System;
using System.Collections.Generic;

namespace ExceleRaptor
{
    public abstract class BindingContext<T>
    {
        protected string _bandName;

        public BindingContext(string bandName)
        {
            _bandName = bandName;
        }

        public BindingContext<T> Bind(string columnName, Func<T, object> getter)
        {
            return this;
        }

        public BindingContext<T> Band<TSrc>(string bandName, Func<T, IEnumerable<TSrc>> dataSource,
                                            Func<SubBindingContext<T, TSrc>, BindingContext<TSrc>> ctx)
        {
            ctx(new SubBindingContext<T, TSrc>(bandName, dataSource));

            return this;
        }
    }
}