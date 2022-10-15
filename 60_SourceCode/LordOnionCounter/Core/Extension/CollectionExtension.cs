using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace LOC.Core.Extension
{
    public static class CollectionExtension
    {
        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TKey, TValue>(this IEnumerable<TValue> source, Func<TValue, TKey> valueSelector)
        {
            return new ConcurrentDictionary<TKey, TValue>
                       (source.ToDictionary(valueSelector));
        }
        /// <summary>
        /// Extended version of the string.Contains() method, 
        /// accepting a [StringComparison] object to perform different kind of comparisons
        /// </summary>
        public static bool Contains(this string source, string value, StringComparison comparisonType)
        {
            return source?.IndexOf(value, comparisonType) >= 0;
        }

        ///// <summary>
        ///// Extended version of the string.Contains() method, 
        ///// accepting a [StringComparison] object to perform different kind of comparisons
        ///// </summary>
        //public static bool Contains(this List<string> source, string keyword, StringComparison comparisonType)
        //{
        //    return source.Any(s => s.Equals(keyword, StringComparison.OrdinalIgnoreCase));
        //}

        /// <summary>
        /// Concurrent conditional deletes
        /// </summary>
        /// <remarks>https://blog.scooletz.com/2016/11/16/concurrent-conditional-deletes/</remarks>
        public static bool TryRemoveConditionally<TKey, TValue>(
        this ConcurrentDictionary<TKey, TValue> dictionary, TKey key, TValue previousValueToCompare)
        {
            var collection = (ICollection<KeyValuePair<TKey, TValue>>)dictionary;
            var toRemove = new KeyValuePair<TKey, TValue>(key, previousValueToCompare);
            return collection.Remove(toRemove);
        }
        public static IDictionary<string, object> ToDictionary(this object source)
        {
            return source.ToDictionary<object>();
        }

        public static IDictionary<string, T> ToDictionary<T>(this object source)
        {
            if (source == null) ThrowExceptionWhenSourceArgumentIsNull();

            var dictionary = new Dictionary<string, T>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
            {
                object value = property.GetValue(source);
                if (IsOfType<T>(value))
                {
                    dictionary.Add(property.Name, (T)value);
                }
            }
            return dictionary;
        }

        private static bool IsOfType<T>(object value)
        {
            return value is T;
        }

        private static void ThrowExceptionWhenSourceArgumentIsNull()
        {
            throw new NullReferenceException("Unable to convert anonymous object to a dictionary. The source anonymous object is null.");
        }

        public static IEnumerable<KeyValuePair<string, T>> PropertiesOfType<T>(this object obj)
        {
            return from p in obj.GetType().GetProperties()
                   where p.PropertyType == typeof(T)
                   select new KeyValuePair<string, T>(p.Name, (T)p.GetValue(obj));
        }

        public static IEnumerable<KeyValuePair<string, object>> PropertiesOfType(this object obj)
        {
            return from p in obj.GetType().GetProperties()
                   select new KeyValuePair<string, object>(p.Name, p.GetValue(obj));
        }

    }
}
