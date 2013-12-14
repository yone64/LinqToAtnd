using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCore;

namespace AtndLibrary
{
    public class AtndDataContext
    {
        public IQueryable<hashEvent> hashEvent 
        {
            get
            {
                return new Query<hashEvent>(new AtndQueryProvider());
            }
        }
    }
}
