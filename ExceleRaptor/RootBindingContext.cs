using System.Collections.Generic;

namespace ExceleRaptor
{
    public class RootBindingContext<T> : BindingContext<T>
    {
        private IEnumerable<T> _data;

        public RootBindingContext(string bandName, IEnumerable<T> data) : base(bandName)
        {
            _data = data;
        }
    }
}