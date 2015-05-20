using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centric.Core.Data.InMem
{
    public class InMemUnitOfWork : IUnitOfWork
    {
      public void Dispose()
      {
      }

      public void Commit()
      {
      }

      public bool LazyLoadingEnabled { get; set; }
    }
}
