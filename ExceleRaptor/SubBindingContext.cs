using System;
using System.Collections.Generic;

namespace ExceleRaptor
{
    public class SubBindingContext<T, TSrc> : BindingContext<TSrc>
    {
        private Func<T, IEnumerable<TSrc>> _dataSource;

        public SubBindingContext(string bandName, Func<T, IEnumerable<TSrc>> dataSource) : base(bandName)
        {
            _dataSource = dataSource;
        }
    }
}