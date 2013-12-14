using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCore;

namespace AtndLibrary
{
    class AtndQueryProvider : QueryProvider
    {
        public override string GetQueryText(System.Linq.Expressions.Expression expression)
        {
            var visitor = new CustomExpressionVisitor();
            var query = visitor.GetQuery(expression);
            return query;
        }

        public override object Execute(System.Linq.Expressions.Expression expression)
        {
            var t = AtndWebClient.QueryEvent(GetQueryText(expression));
            t.Wait();
            return t.Result;
        }
    }
}
