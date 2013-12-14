using LibraryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AtndLibrary
{
    class CustomExpressionVisitor : ExpressionVisitor
    {
        private HashSet<ParameterExpression> _params = new HashSet<ParameterExpression>();
        private Stack<string> _stack = new Stack<string>();

        public string GetQuery(Expression expression)
        {
            Visit(expression);
            return _stack.FirstOrDefault();
        }

        protected override System.Linq.Expressions.Expression VisitMethodCall(System.Linq.Expressions.MethodCallExpression m)
        {
            var e = base.VisitMethodCall(m) as MethodCallExpression;
            if (e.Method.DeclaringType == typeof(System.Linq.Queryable) && e.Method.Name == "Where" && e.Arguments.Count == 2)
            {
                var p1 = _stack.Pop();
                var p2 = _stack.Pop();
                if (string.IsNullOrEmpty(p2))
                {
                    _stack.Push(p1);
                }
                else
                {
                    _stack.Push(p2 + "&" + p1);
                }

            }
            else
            {
                throw new QueryException();
            }
            return e;
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            var e = base.VisitBinary(node) as BinaryExpression;

            var ope = "";

            switch (e.NodeType)
            {
                case ExpressionType.GreaterThan:
                    ope = ">";
                    break;
                case ExpressionType.Equal:
                    ope = "=";
                    break;
                default:
                    throw new QueryException();
            }
            var right = _stack.Pop();
            var left = _stack.Pop();
            _stack.Push(left + ope + right);

            return e;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            var e = base.VisitMember(node) as MemberExpression;

            if (_params.Contains(e.Expression) && (e.Member is PropertyInfo))
            {
                _stack.Push(e.Member.Name);
            }
            else
            {
                throw new QueryException();
            }

            return e;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            if (node.Type == typeof(Query<hashEvent>))
            {
                _stack.Push("");
            }
            else if (node.Type == typeof(string))
            {
                _stack.Push((string)node.Value);
            }
            return base.VisitConstant(node);
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {

            foreach (var item in node.Parameters)
            {
                _params.Add(item);
            }

            return base.VisitLambda<T>(node);
        }
    }
}
