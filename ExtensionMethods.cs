using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
namespace Extension
{
    public static class ExtensionMethods
    {
        /// <exception cref="ArgumentOutOfRangeException">retryCount / sleepInMilliseconds are lower than 0</exception>
        /// <exception cref="AggregateException">suppressExceptions = false and execution got exceptions</exception>
        public static TResult Retry<TResult>(this Func<TResult> func, int retryCount = 1, int sleepInMilliseconds = 0, bool suppressExceptions = false)
        {
            if (retryCount < 0)
                throw new ArgumentOutOfRangeException(nameof(retryCount));
            if (sleepInMilliseconds < 0)
                throw new ArgumentOutOfRangeException(nameof(sleepInMilliseconds));
            List<Exception> exceptions = new List<Exception>();
            TResult result = default(TResult);
            for (int i = 0; i <= retryCount; i++)
            {
                try
                {
                    if (sleepInMilliseconds > 0 && i > 0)
                        Thread.Sleep(sleepInMilliseconds);
                    result = func();
                    return result;
                }
                catch (Exception e)
                {
                    exceptions.Add(e);
                }
            }
            if (!suppressExceptions && exceptions.Count > 0)
                throw new AggregateException(exceptions);
            return result;
        }
        /// <exception cref="ArgumentOutOfRangeException">retryCount / sleepInMilliseconds are lower than 0</exception>
        /// <exception cref="AggregateException">suppressExceptions = false and execution got exceptions</exception>
        public static TResult Retry<T, TResult>(this Func<T, TResult> func, T param1, int retryCount = 1, int sleepInMilliseconds = 0, bool suppressExceptions = false)
        {
            if (retryCount < 0)
                throw new ArgumentOutOfRangeException(nameof(retryCount));
            if (sleepInMilliseconds < 0)
                throw new ArgumentOutOfRangeException(nameof(sleepInMilliseconds));
            List<Exception> exceptions = new List<Exception>();
            TResult result = default(TResult);
            for (int i = 0; i <= retryCount; i++)
            {
                try
                {
                    if (sleepInMilliseconds > 0 && i > 0)
                        Thread.Sleep(sleepInMilliseconds);
                    result = func(param1);
                    return result;
                }
                catch (Exception e)
                {
                    exceptions.Add(e);
                }
            }
            if (!suppressExceptions && exceptions.Count > 0)
                throw new AggregateException(exceptions);
            return result;
        }
        /// <exception cref="ArgumentOutOfRangeException">retryCount / sleepInMilliseconds are lower than 0</exception>
        /// <exception cref="AggregateException">suppressExceptions = false and execution got exceptions</exception>
        public static TResult Retry<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 param1, T2 param2, int retryCount = 1, int sleepInMilliseconds = 0, bool suppressExceptions = false)
        {
            if (retryCount < 0)
                throw new ArgumentOutOfRangeException(nameof(retryCount));
            if (sleepInMilliseconds < 0)
                throw new ArgumentOutOfRangeException(nameof(sleepInMilliseconds));
            List<Exception> exceptions = new List<Exception>();
            TResult result = default(TResult);
            for (int i = 0; i <= retryCount; i++)
            {
                try
                {
                    if (sleepInMilliseconds > 0 && i > 0)
                        Thread.Sleep(sleepInMilliseconds);
                    result = func(param1, param2);
                    return result;
                }
                catch (Exception e)
                {
                    exceptions.Add(e);
                }
            }
            if (!suppressExceptions && exceptions.Count > 0)
                throw new AggregateException(exceptions);
            return result;
        }
        /// <exception cref="ArgumentOutOfRangeException">retryCount / sleepInMilliseconds are lower than 0</exception>
        /// <exception cref="AggregateException">suppressExceptions = false and execution got exceptions</exception>
        public static TResult Retry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 param1, T2 param2, T3 param3, int retryCount = 1, int sleepInMilliseconds = 0, bool suppressExceptions = false)
        {
            if (retryCount < 0)
                throw new ArgumentOutOfRangeException(nameof(retryCount));
            if (sleepInMilliseconds < 0)
                throw new ArgumentOutOfRangeException(nameof(sleepInMilliseconds));
            List<Exception> exceptions = new List<Exception>();
            TResult result = default(TResult);
            for (int i = 0; i <= retryCount; i++)
            {
                try
                {
                    if (sleepInMilliseconds > 0 && i > 0)
                        Thread.Sleep(sleepInMilliseconds);
                    result = func(param1, param2, param3);
                    return result;
                }
                catch (Exception e)
                {
                    exceptions.Add(e);
                }
            }
            if (!suppressExceptions && exceptions.Count > 0)
                throw new AggregateException(exceptions);
            return result;
        }
        /// <exception cref="ArgumentOutOfRangeException">retryCount / sleepInMilliseconds are lower than 0</exception>
        /// <exception cref="AggregateException">suppressExceptions = false and execution got exceptions</exception>
        public static TResult Retry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 param1, T2 param2, T3 param3, T4 param4, int retryCount = 1, int sleepInMilliseconds = 0, bool suppressExceptions = false)
        {
            if (retryCount < 0)
                throw new ArgumentOutOfRangeException(nameof(retryCount));
            if (sleepInMilliseconds < 0)
                throw new ArgumentOutOfRangeException(nameof(sleepInMilliseconds));
            List<Exception> exceptions = new List<Exception>();
            TResult result = default(TResult);
            for (int i = 0; i <= retryCount; i++)
            {
                try
                {
                    if (sleepInMilliseconds > 0 && i > 0)
                        Thread.Sleep(sleepInMilliseconds);
                    result = func(param1, param2, param3, param4);
                    return result;
                }
                catch (Exception e)
                {
                    exceptions.Add(e);
                }
            }
            if (!suppressExceptions && exceptions.Count > 0)
                throw new AggregateException(exceptions);
            return result;
        }
        /// <exception cref="ArgumentOutOfRangeException">retryCount / sleepInMilliseconds are lower than 0</exception>
        /// <exception cref="AggregateException">suppressExceptions = false and execution got exceptions</exception>
        public static TResult Retry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, int retryCount = 1, int sleepInMilliseconds = 0, bool suppressExceptions = false)
        {
            if (retryCount < 0)
                throw new ArgumentOutOfRangeException(nameof(retryCount));
            if (sleepInMilliseconds < 0)
                throw new ArgumentOutOfRangeException(nameof(sleepInMilliseconds));
            List<Exception> exceptions = new List<Exception>();
            TResult result = default(TResult);
            for (int i = 0; i <= retryCount; i++)
            {
                try
                {
                    if (sleepInMilliseconds > 0 && i > 0)
                        Thread.Sleep(sleepInMilliseconds);
                    result = func(param1, param2, param3, param4, param5);
                    return result;
                }
                catch (Exception e)
                {
                    exceptions.Add(e);
                }
            }
            if (!suppressExceptions && exceptions.Count > 0)
                throw new AggregateException(exceptions);
            return result;
        }
        /// <exception cref="ArgumentOutOfRangeException">retryCount / sleepInMilliseconds are lower than 0</exception>
        /// <exception cref="AggregateException">suppressExceptions = false and execution got exceptions</exception>
        public static TResult Retry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, int retryCount = 1, int sleepInMilliseconds = 0, bool suppressExceptions = false)
        {
            if (retryCount < 0)
                throw new ArgumentOutOfRangeException(nameof(retryCount));
            if (sleepInMilliseconds < 0)
                throw new ArgumentOutOfRangeException(nameof(sleepInMilliseconds));
            List<Exception> exceptions = new List<Exception>();
            TResult result = default(TResult);
            for (int i = 0; i <= retryCount; i++)
            {
                try
                {
                    if (sleepInMilliseconds > 0 && i > 0)
                        Thread.Sleep(sleepInMilliseconds);
                    result = func(param1, param2, param3, param4, param5, param6);
                    return result;
                }
                catch (Exception e)
                {
                    exceptions.Add(e);
                }
            }
            if (!suppressExceptions && exceptions.Count > 0)
                throw new AggregateException(exceptions);
            return result;
        }
        /// <exception cref="ArgumentOutOfRangeException">retryCount / sleepInMilliseconds are lower than 0</exception>
        /// <exception cref="AggregateException">suppressExceptions = false and execution got exceptions</exception>
        public static async Task RetryAsync(this Func<Task> func, int retryCount = 1, int sleepInMilliseconds = 0, bool suppressExceptions = false)
        {
            if (retryCount < 0)
                throw new ArgumentOutOfRangeException(nameof(retryCount));
            if (sleepInMilliseconds < 0)
                throw new ArgumentOutOfRangeException(nameof(sleepInMilliseconds));
            List<Exception> exceptions = new List<Exception>();
            for (int i = 0; i <= retryCount; i++)
            {
                try
                {
                    if (sleepInMilliseconds > 0 && i > 0)
                        Thread.Sleep(sleepInMilliseconds);
                    await func();
                }
                catch (Exception e)
                {
                    exceptions.Add(e);
                }
            }
            if (!suppressExceptions && exceptions.Count > 0)
                throw new AggregateException(exceptions);
        }
        /// <exception cref="ArgumentOutOfRangeException">retryCount / sleepInMilliseconds are lower than 0</exception>
        /// <exception cref="AggregateException">suppressExceptions = false and execution got exceptions</exception>
        public static async Task<TResult> RunAsync<TResult>(this Func<TResult> func)
        {
            return await Task.Run(func);
        }
        public static string EmptyIfNull(this String str)
        {
            return str ?? string.Empty;
        }
        /// <exception cref="ArgumentNullException">any of source / list is null </exception>
        public static bool In<T>(this T source, params T[] list)
        {
            if (null == source) throw new ArgumentNullException(nameof(source));
            if (null == list) throw new ArgumentNullException(nameof(list));
            return list.Contains(source);
        }
        public static DateTime? ToDate(this string str)
        {
            return DateTime.TryParse(str, out DateTime dateTime) ? new DateTime?(dateTime) : null;
        }
        public static DateTime? ToDate(this string str, DateTime? defaultValue)
        {
            return DateTime.TryParse(str, out DateTime dateTime) ? dateTime : defaultValue;
        }
        public static DateTime ToDate(this string str, DateTime defaultValue)
        {
            return DateTime.TryParse(str, out DateTime dateTime) ? dateTime : defaultValue;
        }
        public static int ToInt<T>(this T value)
        {
            return int.TryParse(value?.ToString(), out int result) ? result : 0;
        }
        public static int ToInt<T>(this T value, int defaultValue)
        {
            return int.TryParse(value?.ToString(), out int result) ? result : defaultValue;
        }
        public static int? ToInt<T>(this T value, int? defaultValue)
        {
            return int.TryParse(value?.ToString(), out int result) ? result : defaultValue;
        }
        public static float ToFloat<T>(this T value)
        {
            return float.TryParse(value?.ToString(), out float result) ? result : 0;
        }
        public static float ToFloat<T>(this T value, float defaultValue)
        {
            return float.TryParse(value?.ToString(), out float result) ? result : defaultValue;
        }
        public static float? ToFloat<T>(this T value, float? defaultValue)
        {
            return float.TryParse(value?.ToString(), out float result) ? result : defaultValue;
        }
        public static bool ToBool<T>(this T value, bool defaultValue)
        {
            return bool.TryParse(value?.ToString(), out bool result) ? result : defaultValue;
        }
        public static bool? ToBool<T>(this T value, bool? defaultValue)
        {
            return bool.TryParse(value?.ToString(), out bool result) ? result : defaultValue;
        }
        public static T ToEnum<T>(this string str,T defaultValue) where T : struct
        {
            return Enum.TryParse<T>(str, out T result) ? result : defaultValue;
        }
        public static T Do<T>(this T t, Action<T> action)
        {
            action(t);
            return t;
        }
        public static T DoIfNotNull<T>(this T t, Action<T> action) where T : class
        {
            if (t != null)
                action(t);
            return t;
        }
        public static T? DoIfNotNull<T>(this T? t, Action<T> action) where T : struct
        {
            if (t != null)
                action(t.Value);
            return t;
        }
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> iEnumerable)
        {
            return iEnumerable == null || !iEnumerable.Any();
        }
        public static IList<T> ToListIfNotNullOrEmpty<T>(this IList<T> iList)
        {
            return iList.IsNullOrEmpty() ? null : iList.ToList();
        }
        public static IEnumerable<T> ToListIfNotNullOrEmpty<T>(this IEnumerable<T> iEnumerable)
        {
            return iEnumerable.IsNullOrEmpty() ? null : iEnumerable;
        }
        public static bool EqualsIgnoreCase(this string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }
        public static Dictionary<string, object> ToDictionary(this object o)
        {
            var dictionary = new Dictionary<string, object>();
            foreach (var propertyInfo in o.GetType().GetProperties())
            {
                if (propertyInfo.GetIndexParameters().Length == 0)
                    dictionary.Add(propertyInfo.Name, propertyInfo.GetValue(o, null));
            }
            return dictionary;
        }
        public static bool HasRows(this DataTable dt)
        {
            return dt != null && dt.Rows.Count > 0;
        }
    }
}
