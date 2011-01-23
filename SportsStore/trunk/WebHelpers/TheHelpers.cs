using System;
using System.Linq;


namespace WebHelpers.Extensions
{
    public static class Helpers
    {
        public static IQueryable<T> LimitAndOffset<T>(this IQueryable<T> q, int pageSize, int pageOffset)
        {
            return q.Skip((pageOffset - 1) * pageSize).Take(pageSize);
        }
    }
}
