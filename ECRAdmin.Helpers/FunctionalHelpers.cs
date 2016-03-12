using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.Helpers
{
    public static class FunctionalHelpers
    {
        public static T Tee<T>(this T value, Action<T> sideEffect)
        {
            sideEffect(value);
            return value;
        }

        public static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>(Func<T1, T2, TResult> func)
        {
            return a => b => func(a, b);
        }

        public static Func<A, C> Compose<A, B, C>(this Func<B, C> f, Func<A, B> g)
        {
            return a => f(g(a));
        }

        public static TResult Apply<T, TResult>(this T value, Func<T, TResult> func)
        {
            return func(value);
        }
    }
}
