using System;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace Services
{
    public static class Json
    {
        public static string ToStringJson(object item, Formatting formating = Formatting.None)
        {
            try
            {
                if (item == null) return "";
                return JsonConvert.SerializeObject(item, new JsonSerializerSettings()
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore,
                    Formatting = formating
                });
            }
            catch (ThreadAbortException) { return ""; }
            catch (OperationCanceledException) { return ""; }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex, "ItemType:" + item.GetType().ToString());
                return "";
            }
        }

        public static string ToStringJson(object item, JsonConverter converter)
        {
            try
            {
                return item == null ? "" : JsonConvert.SerializeObject(item, converter);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex, "ItemType:" + item.GetType().ToString());
                return "";
            }
        }

        public static byte[] ToBytesJson(object item)
        {
            try
            {
                return item == null
                    ? null
                    : Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(item,
                        new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.Ignore }));
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }


        public static T FromJson<T>(this string data)
        {
            try
            {
                if (string.IsNullOrEmpty(data) || data.Trim() == "")
                    return default(T);
                return JsonConvert.DeserializeObject<T>(data);
            }
            catch (ThreadAbortException)
            {
                return default(T);
            }
            catch
            {
                return default(T);
            }
        }

        public static T FromJson<T>(string data, JsonConverter converter)
        {
            try
            {
                if (string.IsNullOrEmpty(data) || data.Trim() == "")
                    return default(T);
                return JsonConvert.DeserializeObject<T>(data, converter);
            }
            catch (ThreadAbortException)
            {
                return default(T);
            }
            catch
            {
                if (string.IsNullOrEmpty(data))
                    data = "NullOrEmpty";
                return default(T);
            }
        }

        public static T FromJson<T>(byte[] bytes)
        {
            try
            {
                return bytes != null ? FromJson<T>(Encoding.UTF8.GetString(bytes, 0, bytes.Length)) : default(T);
            }
            catch (ThreadAbortException)
            {
                return default(T);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                Console.WriteLine("FromJson:" + ex);
                return default(T);
            }
        }
    }
}
