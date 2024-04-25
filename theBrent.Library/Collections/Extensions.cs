﻿using System.Collections;

namespace theBrent.Library.Collections
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T element in source) action(element);
        }

        public static void ForEach<T>(this IEnumerable source, Action<T> action)
        {
            foreach (T element in source) action(element);
        }

        public static void ForEach<TKey, TValue>(this IDictionary<TKey, TValue> source, Action<TKey, TValue> action)
        {
            foreach (KeyValuePair<TKey, TValue> element in source) action(element.Key, element.Value);
        }

        public static void ForEach<T>(this Array source, Action<T> action)
        {
            foreach (T element in source) action(element);
        }

        public static int ValueOf<T>(this T item) where T : Enum => Convert.ToInt32(item);
    }
}