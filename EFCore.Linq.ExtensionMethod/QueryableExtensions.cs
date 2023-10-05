﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Linq.ExtensionMethod
{
    internal static class QueryableExtensions
    {
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> queryable,bool condition, Expression<Func<T,bool>> predicate)
        {
            if(condition)
            {
                return queryable.Where(predicate);
            }
            return queryable;
        }
    }
}
