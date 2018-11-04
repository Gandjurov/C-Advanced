using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Overview
{
    public static class CollectionExtentions
    {
        public static string TrimDashes(this string input) => input.Trim('-');

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }

            return collection;
        }

    }
}
