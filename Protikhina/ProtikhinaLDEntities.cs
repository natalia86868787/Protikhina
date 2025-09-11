using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Protikhina
{
    internal class ProtikhinaLDEntities : IDisposable
    {
        public IEnumerable<object> Users { get; internal set; }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}