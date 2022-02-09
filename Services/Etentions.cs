using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Services
{
    public static class Extentions
    {
        public static string GetDisplay<T>(this T enumItem)
        {
            try
            {
                if (typeof(T).IsEnum)
                {
                    return ((PersianNameAttribute.PersianName)typeof(T).GetFields()
                        .Single(rec => rec.Name == Enum.GetName(typeof(T), enumItem)).GetCustomAttributes(false)
                        .First(rec => rec is PersianNameAttribute.PersianName)).Text;
                }

                return enumItem.ToString();
            }
            catch
            {
                return enumItem.ToString();
            }
        }
        public static bool ParseToBoolean(this string Input, bool def = false)
        {
            if (string.IsNullOrEmpty(Input))
                return def;
            if (Input.Trim() == "")
                return def;

            bool ret = def;
            if (!bool.TryParse(Input, out ret))
                return def;
            return ret;
        }
        public static float ParseTofloat(this string value, float def = 0)
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
                return def;
            float ret = def;
            float.TryParse(value, out ret);
            return ret;
        }
        public static DateTime ParseToDate(this string Input, DateTime? def = null)
        {
            if (string.IsNullOrEmpty(Input))
                return def ?? DateTime.Now;
            DateTime ret = def ?? DateTime.Now;

            if (DateTime.TryParse(Input, out ret))
                return ret;
            else
                return def ?? DateTime.Now;
        }
        public static decimal ParseToDecimal(this string value, decimal def = 0)
        {
            if (string.IsNullOrEmpty(value))
                return def;
            value = value.Replace(".", "").Replace("/", "").Trim();
            return decimal.TryParse(value, out var ret) ? ret : def;
        }
        public static double ParseToDouble(this string value, double def = 0)
        {
            string xstr = value.Trim();
            if (string.IsNullOrEmpty(xstr))
                return def;
            //xstr  = xstr .TXTQT.Text.Replace("/", ".")
            return double.TryParse(value, out var ret) ? ret : def;
        }
        public static int ParseToInt(this string value, int def = 0)
        {
            string xstr = value?.Trim();
            if (xstr == "")
                return def;
            return int.TryParse(value, out var ret) ? ret : def;
        }
        public static long ParseToLong(this string value, long def = 0)
        {
            string xstr = value.Trim();
            if (xstr == "")
                return def;
            return long.TryParse(value, out var ret) ? ret : def;
        }
        public static short ParseToShort(this string value, short def = 0)
        {
            string xstr = value.Trim();
            if (xstr == "")
                return def;

            return short.TryParse(value, out var ret) ? ret : def;
        }
        public static SortableBindingList<T> ToSortableBindingList<T>(this IEnumerable<T> items)
        {
            var ret = new SortableBindingList<T>();
            try
            {
                if (items != null && items.Any())
                    foreach (var item in items)
                        ret.Add(item);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }

            return ret;
        }
        public static string ThreeSeparator(this decimal value) => value.ToString("#,0");
        private const int ChunckSizeKB = 100000;
        public static readonly DateTime MinValidDateTime = DateTime.Parse("1900/01/01 00:00:00");
        public static async Task<ReturnedSaveFuncInfo> FileTryReplceadeAsync(string FullFilePath, byte[] data, short tryCount = 10)
        {
            var ret = new ReturnedSaveFuncInfo();
            try
            {
                if (File.Exists(FullFilePath))
                    File.Delete(FullFilePath);
                File.WriteAllBytes(FullFilePath, data);
                return ret;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                ret.AddReturnedValue(ex);
            }

            try
            {
                File.WriteAllBytes(FullFilePath, data);
                return new ReturnedSaveFuncInfo();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                ret.AddReturnedValue(ex);
            }
            if (tryCount > 0 && ret.HasError)
            {
                await Task.Delay(5 * 1000);
                return await FileTryReplceadeAsync(FullFilePath, data, --tryCount);
            }
            return ret;
        }
        public static string ToBase64(this string data)
        {
            try
            {
                return Convert.ToBase64String(Encoding.Unicode.GetBytes(data));
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "";
            }
        }
        public static string FromBase64(this string data)
        {
            try
            {
                return Encoding.Unicode.GetString(Convert.FromBase64String(data));
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "";
            }
        }
        public static void CopyPropertiesTo<T, U>(this T source, U dest)
        {

            try
            {
                if (source is System.Collections.IList)
                {
                    foreach (var item in (System.Collections.IEnumerable)(object)source)
                    {
                        var myListElementType = dest.GetType().GetGenericArguments().Single();
                        var instance = Activator.CreateInstance(myListElementType);

                        item.CopyPropertiesTo_(instance);
                        ((System.Collections.IList)dest).Add(instance);
                    }
                }
                else
                    CopyPropertiesTo_(source, dest);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public static WebPageContainer<T> ProgressPages<T>(this IEnumerable<T> items, int eachPageCount, int currentPageNumber) where T : class, new()
        => WebPageContainer<T>.GeneratePageItems(items?.ToList(), eachPageCount, currentPageNumber);
        private static void CopyPropertiesTo_<T, U>(this T source, U dest)
        {
            try
            {
                var sourceProperties = source.GetType().GetProperties().Where(x => x.CanRead);
                var destProperties = dest.GetType().GetProperties().Where(x => x.CanWrite);

                foreach (var sourceProp in sourceProperties)
                {
                    foreach (var destProp in destProperties)
                    {
                        try
                        {
                            if (sourceProp.Name != destProp.Name) continue;
                            if (sourceProp.PropertyType.IsEnum && destProp.PropertyType.IsEnum)
                            {
                                var sourceEnumName = Enum.GetName(sourceProp.GetValue(source).GetType(), sourceProp.GetValue(source));
                                var t1 = source.GetType();
                                foreach (var destEnum in Enum.GetValues(destProp.PropertyType))
                                    if (destEnum.ToString() == sourceEnumName)
                                    {
                                        destProp.SetValue(dest, destEnum);
                                        break;
                                    }
                            }
                            else if (sourceProp.PropertyType == destProp.PropertyType)
                            {
                                destProp.SetValue(dest, sourceProp.GetValue(source));
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            WebErrorLog.ErrorInstence.StartErrorLog(ex);
                            Console.WriteLine(ex);
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public static Task CancelTask(CancellationToken token)
        {
            try
            {
                return Task.Run(async () =>
                {
                    while (true)
                    {
                        if (token.IsCancellationRequested) return;
                        await Task.Delay(100);
                    }
                });
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static TimeSpan ParsToTimeSpan(this string strTime)
        {
            var timeDef = new DateTime(0).TimeOfDay;
            var msgError = $"StrTime first {strTime}";
            var i = 0;
            try
            {
                strTime = strTime.Trim();
                i = 1;
                if (string.IsNullOrEmpty(strTime) || strTime.Length < 3 || !strTime.Contains(":"))
                    return timeDef;
                i = 2;
                var arr = strTime.Split(':');
                var strHh = arr[0].RemoveNoNumbers("");
                msgError += " str_hh=" + strHh;
                i = 3;
                var strMm = arr[1].RemoveNoNumbers("");
                msgError += " str_mm=" + strMm;
                i = 4;
                var strSs = "00";
                if (arr.Length > 2)
                    strSs = arr[2].RemoveNoNumbers("");

                var hh = Convert.ToInt32(strHh);
                msgError += " hh=" + hh;
                i = 5;
                var mm = Convert.ToInt32(strMm);
                msgError += " mm=" + mm;
                i = 6;
                var ss = Convert.ToInt32(strSs);
                msgError += " ss=" + ss;
                i = 6;
                return new TimeSpan(hh, mm, ss);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex, $"{msgError} line {i}");
            }
            return timeDef;
        }
        public static string RemoveCharactersForLinkSearch(this string value, string validChars = @"(1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ/-+()×@#_[].$&ابپتثجچحخدذرزژسشصضطظعغفقکگلمنوهئیءآاًهٔة )ـ")
        {
            var ret = "";
            try
            {
                if (string.IsNullOrEmpty(value)) return "";
                value = value.FixString();

                foreach (var item in value.ToCharArray())
                    if (validChars.Contains(item))
                        ret += item;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            return ret;
        }
        public static string KeepCharacters(this string value, string validChars = @"1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_")
        {
            var ret = "";
            try
            {
                if (string.IsNullOrEmpty(value)) return "";
                value = value.FixString();

                foreach (var item in value.ToCharArray())
                    if (validChars.Contains(item))
                        ret += item;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            return ret;
        }
        public static bool Compare(this List<byte> item1, List<byte> item2)
        {
            try
            {
                if (item1 == null && item2 == null) return true;

                if (item1 == null || item2 == null) return false;

                if (item1.Count() != item2.Count()) return false;

                for (var i = 0; i < item1.Count(); i++)
                    if (item1[i] != item2[i])
                        return false;

                return true;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return false;
            }
        }
        public static async Task RaiseEvent<T>(Func<object, T, Task> handler, object sender, T args, CancellationToken token, int TimeOutSeconds = 60)
        {
            try
            {
                if (handler == null) return;

                var invocationList = handler.GetInvocationList();
                var handlerTasks = new List<Task>();

                foreach (var invocationItem in invocationList)
                {
                    if (invocationItem != null)
                    {
                        handlerTasks.Add(Task.Run(() =>
                        {
                            try
                            {
                                ((Func<object, T, Task>)invocationItem)(sender, args);
                            }
                            catch (Exception ex)
                            {
                                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                            }
                        }));
                    }
                }
                await Task.WhenAll(handlerTasks);
            }
            catch (OperationCanceledException) { throw; }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private static ConcurrentDictionary<string, int> cach = new ConcurrentDictionary<string, int>();
        private static int GetObjectSize(object testObject)
        {
            try
            {
                switch (testObject)
                {
                    case byte b: return 1;
                    case string s: return s.Length * 2;
                }

                if (testObject == null)
                    return 200;

                if (cach.TryGetValue(testObject.GetType().ToString(), out int size))
                    return size;

                var length = Json.ToBytesJson(testObject).Length * 2;
                cach.TryAdd(testObject.GetType().ToString(), length);
                return length;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return 200;
            }
        }
        public static List<List<T>> ChunkList<T>(this IEnumerable<T> lst, int chunkSizeKBytes, int maxChunkCount = 1000)
        {
            try
            {
                if (lst == null || !lst.Any()) return null;

                var temp = lst.FirstOrDefault();
                var partSize = GetObjectSize(lst.FirstOrDefault());

                chunkSizeKBytes *= 1024;

                var ret = new List<List<T>>();
                var tempList = new List<T>();
                foreach (var item in lst)
                {
                    tempList.Add(item);
                    if (tempList.Count > maxChunkCount || partSize * tempList.Count > chunkSizeKBytes)
                    {
                        ret.Add(tempList);
                        tempList = new List<T>();
                    }
                }
                if (tempList.Count > 0) ret.Add(tempList);

                return ret;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static string GetMonthName(this int month)
        {
            var strItem = "";

            switch (month)
            {
                case 1:
                    strItem = "فروردین";
                    break;
                case 2:
                    strItem = "اردیبهشت";
                    break;
                case 3:
                    strItem = "خرداد";
                    break;
                case 4:
                    strItem = "تیر";
                    break;
                case 5:
                    strItem = "مرداد";
                    break;
                case 6:
                    strItem = "شهریور";
                    break;
                case 7:
                    strItem = "مهر";
                    break;
                case 8:
                    strItem = "آبان";
                    break;
                case 9:
                    strItem = "آذر";
                    break;
                case 10:
                    strItem = "دی";
                    break;
                case 11:
                    strItem = "بهمن";
                    break;
                case 12:
                    strItem = "اسفند";
                    break;
                default:
                    strItem = "";
                    break;
            }
            return strItem;
        }
        public static DateTime GotoEndYear(this DateTime pdate)
        {
            try
            {
                var dsh = new System.Globalization.PersianCalendar();
                var yy = dsh.GetYear(pdate);
                var dd = Calendar.EndDayOfMonth(12, yy);
                var dateM = Calendar.ShamsiToMiladi($"{yy}/{12}/{dd}");
                dateM = dateM.Date.AddDays(1).AddSeconds(-1);
                return dateM;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            return DateTime.Now;
        }
        public static int GetYearSh(this DateTime pdate)
        {
            try
            {
                var dsh = new System.Globalization.PersianCalendar();
                var yy = dsh.GetYear(pdate);
                return yy;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            return 0;
        }
        public static string GetTashkhisValue(this decimal pValue)
        {
            try
            {
                if (pValue > 0) return "بس";
                if (pValue < 0) return "بد";
                return "";
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "";
            }
        }
        public static string GetTimeFormat(this string pTime)
        {
            pTime = pTime.Trim();

            var h = 0;
            var m = 0;
            try
            {
                pTime = pTime.RemoveNoNumbers(":").Replace("::", ":");
                if (string.IsNullOrEmpty(pTime)) return null;
                var lst = pTime.Split(':');
                switch (lst.Length)
                {
                    case 1 when lst[0].Length == 4:
                        {
                            h = lst[0].Substring(0, 2).ParseToShort();
                            m = lst[0].Substring(2, 2).ParseToShort();
                            if (h > 24 || m > 59 || (h == 24 && m > 0)) return null;
                            return h.ToString("00") + ":" + m.ToString("00");
                        }
                    case 1 when lst[0].ParseToShort() > 0 && lst[0].ParseToShort() <= 24:
                        return lst[0].ParseToShort().ToString("00") + ":00";
                    case 1:
                        return null;
                }

                if (lst.Length > 0)
                {
                    if (lst[0].Trim().ParseToShort() >= 0 && lst[0].Trim().ParseToShort() <= 24)
                        h = lst[0].ParseToShort();
                    else
                        return null;
                }

                if (lst.Length > 1)
                {
                    if (lst[1].Trim().ParseToShort() >= 0 && lst[1].Trim().ParseToShort() < 60)
                        m = lst[1].ParseToShort();
                    else
                        return null;
                }
                if (h == 24 && m > 0) return null;
                return h.ToString("00") + ":" + m.ToString("00");
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex, $"V:6.4.8//مقداری که باعث شده خطا ایجاد شود {pTime}");
                return null;
            }
        }
        public static int GetNthIndex(this string src, string sch, int n)
        {
            var count = 1;
            var xstr = src;
            for (var i = 0; i < src.Length;)
            {
                var j = xstr.IndexOf(sch, i, StringComparison.Ordinal);
                if (j == -1 || n < 1 || count == n) return j;

                count++;
                i = j + 1;
            }
            return -1;
        }
        public static void UpLoadFrom(ref object desItem, object srcItem)
        {
            try
            {
                var queryMaster = desItem.GetType().GetProperties();
                if (queryMaster.Length <= 0)
                {
                    desItem = queryMaster;
                    return;
                }
                foreach (var piMaster in queryMaster)
                {
                    if (piMaster.CanWrite)
                    {
                        var xcAccThisObj = piMaster.GetValue(desItem, null);
                        var xcAccSrcObj = piMaster.GetValue(srcItem, null);

                        UpLoadFrom(ref xcAccThisObj, xcAccSrcObj);
                    }
                }
            }
            catch (Exception e)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(e);
            }
        }
        public static string UntilMaxLen(this string src, int len)
        {
            try
            {
                return string.IsNullOrEmpty(src) || len >= src.Length ? src : src.Substring(0, len);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            return "";
        }
        public static string GetShortDateSh(this string datesh)
        {
            try
            {
                if (string.IsNullOrEmpty(datesh)) return "";

                datesh = datesh.Replace(@"/", "");
                if (datesh.Length > 6)
                    datesh = datesh.Substring(2);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            return datesh;
        }
        public static string PersianDayName(this string persianDate)
        {

            try
            {
                var res = Calendar.ShamsiToMiladi(persianDate).DayOfWeek;
                switch (res)
                {
                    case DayOfWeek.Saturday: return "شنبه";
                    case DayOfWeek.Sunday: return "یکشنبه";
                    case DayOfWeek.Monday: return "دوشنبه";
                    case DayOfWeek.Tuesday: return "سه شنبه";
                    case DayOfWeek.Wednesday: return "چهار شنبه";
                    case DayOfWeek.Thursday: return "پنج شنبه";
                    case DayOfWeek.Friday: return "جمعه";
                    default: return "";
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            return "";
        }
        public static string Reverse(this string str)
        {
            try
            {
                var charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            return "";
        }
        public static string TimeDifferenceToString(this DateTime information)
        {
            try
            {
                if (DateTime.Now.Subtract(information).TotalSeconds < 30)
                    return "هم اکنون";
                if (DateTime.Now.Subtract(information).TotalSeconds < 100)
                    return "لحظاتی پیش";
                if (DateTime.Now.Subtract(information).TotalMinutes < 60)
                    return DateTime.Now.Subtract(information).TotalMinutes.ToString("N0") + "دقیقه قبل";
                if (DateTime.Now.Subtract(information).TotalDays > 365)
                    return "هرگز";
                if (DateTime.Now.Subtract(information).TotalDays > 30 * 6)
                    return "6 ماه پیش";
                if (DateTime.Now.Subtract(information).TotalDays > 30 * 3)
                    return "3 ماه پیش";
                if (DateTime.Now.Subtract(information).TotalDays > 30 * 1)
                    return "1 ماه پیش";
                if (DateTime.Now.Subtract(information).TotalDays > 7)
                    return DateTime.Now.Subtract(information).TotalDays.ToString("N0") + "روز پیش";
                if (DateTime.Now.Subtract(information).TotalHours > 1 &&
                         DateTime.Now.Subtract(information).TotalHours <= 24)
                    return DateTime.Now.Subtract(information).TotalHours.ToString("N0") + "ساعت پیش";
                return Calendar.MiladiToShamsi(information) + " " + information.ToString("T");
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "Error";
            }
        }
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            var seenKeys = new HashSet<TKey>();
            foreach (var element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                    yield return element;
            }
        }
        public static string CalcHashBase64(this string password)
        => Convert.ToBase64String(CalcHash(password));
        public static byte[] CalcHash(this string password)
        {
            try
            {
                SHA256 hash = new SHA256CryptoServiceProvider();
                return hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static string TimeDifferenceToHexColor(this DateTime information)
        {
            try
            {
                if (DateTime.Now.Subtract(information).TotalMinutes < 1)
                    return "#008000";
                if (DateTime.Now.Subtract(information).TotalSeconds < 30)
                    return "#00FF00";//color = Color.Lime;
                if (DateTime.Now.Subtract(information).TotalMinutes < 60)
                    return "#00BFFF";//color = Color.DeepSkyBlue;
                if (DateTime.Now.Subtract(information).TotalDays > 365)
                    return "#FF0000";//color = Color.Red;
                if (DateTime.Now.Subtract(information).TotalDays > 30 * 6)
                    return "#DC143C";//color = Color.Crimson;
                if (DateTime.Now.Subtract(information).TotalDays > 30 * 3)
                    return "#DB7093";//color = Color.PaleVioletRed;
                if (DateTime.Now.Subtract(information).TotalDays > 30 * 1)
                    return "#D2691E";//color = Color.Chocolate;
                if (DateTime.Now.Subtract(information).TotalDays > 7)
                    return "#FF7F50";//color = Color.Coral;
                if (DateTime.Now.Subtract(information).TotalHours > 1 &&
                         DateTime.Now.Subtract(information).TotalHours <= 24)
                    return "#DAA520"; //color = Color.Yellow;
                return "#00008B";//color = Color.Beige;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "#000000";
            }
        }
        public static async Task<WebResponse<T>> GetFromApi<T>(this string url, short tryCount = 3, Dictionary<string, string> headers = null)
        {
            var result = new WebResponse<T>();
            try
            {
                using (var clientHttp = new HttpClient())
                {
                    clientHttp.Timeout = new TimeSpan(0, 2, 0);
                    if (headers != null)
                        foreach (var head in headers)
                            clientHttp.DefaultRequestHeaders.Add(head.Key, head.Value);
                    var response = await clientHttp.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                        result = (await response.Content.ReadAsStringAsync()).FromJson<WebResponse<T>>();
                    else
                    {
                        result.Describtion = "IsSuccessStatusCode is false";
                        result.ResponseStatus = ResponseStatus.ErrorInServer;
                    }
                }
            }
            catch (Exception ex)
            {
                if (tryCount > 0)
                {
                    await Task.Delay(1000);
                    return await GetFromApi<T>(url, --tryCount);
                }
                if (!ex.Message.ToLower().Contains("An error occurred while sending the request.".ToLower()))
                    WebErrorLog.ErrorInstence.StartErrorLog(ex);
                result.Describtion = ex.Message;
                result.ResponseStatus = ResponseStatus.ErrorInClient;
            }
            return result;
        }
        public static async Task<WebResponse<T>> PostToApi<T, U>(U item, string url, Guid? cusGuid = null) where U : new()
        {
            try
            {
                using (var clientHttp = new HttpClient())
                {
                    clientHttp.Timeout = new TimeSpan(0, 2, 15);
                    if (cusGuid != null && cusGuid != Guid.Empty)
                        clientHttp.DefaultRequestHeaders.Add("cusGuid", cusGuid.Value.ToString());
                    var temp = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                    var response = await clientHttp.PostAsync(url, temp);
                    if (!response.IsSuccessStatusCode)
                        return new WebResponse<T>(ResponseStatus.ErrorInServer, $"کد خطا:{response.StatusCode}");
                    WebResponse<T> result = null;

                    var strRes = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(strRes))
                    {
                        var tmp = strRes.FromJson<T>();
                        if (tmp != null)
                            result = new WebResponse<T>(ResponseStatus.Success, data: tmp);
                    }
                    else
                        result = new WebResponse<T>(ResponseStatus.ErrorInClient, "خطا در تبدیل داده ها");

                    return result;
                }
            }
            catch (OperationCanceledException ex) { return new WebResponse<T> { Describtion = ex.Message, ResponseStatus = ResponseStatus.ErrorInServer }; }
            catch (ThreadAbortException ex) { return new WebResponse<T> { Describtion = ex.Message, ResponseStatus = ResponseStatus.ErrorInServer }; }
            catch (WebException ex) { return new WebResponse<T> { Describtion = ex.Message, ResponseStatus = ResponseStatus.ErrorInServer }; }
            catch (HttpRequestException ex) { return new WebResponse<T> { Describtion = ex.Message, ResponseStatus = ResponseStatus.ErrorInServer }; }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return new WebResponse<T> { Describtion = ex.Message, ResponseStatus = ResponseStatus.ErrorInServer };
            }
        }
        public static long VersionStringToLong(this string version)
        {
            try
            {
                if (string.IsNullOrEmpty(version))
                    return 0;
                var splited = version.SplitString();
                var res = "";
                if (splited != null && splited.Any())
                    foreach (var splitedPart in splited)
                    {
                        var temp = splitedPart;
                        while (temp.Length < 2)
                            temp = $"0{temp}";
                        res += temp;
                    }

                while (res.Length < 9)
                    res = $"{res}0";
                if (res.Length > 9)
                    res = res.Substring(0, 9);
                return res.ParseToLong();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return 0;
            }
        }
        public static decimal Round(this decimal value, decimal round = 0)
        {
            try
            {
                if (round <= 0)
                    return value;
                return (value - (value % round)); ;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return value;
            }
        }
        public static string AccountDiagnosis(this decimal value)
        {
            try
            {
                if (value < 0) return "بدهکار";
                if (value > 0) return "بستانکار";
                return "بی حساب";
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "";
            }
        }
        public static string AccountDiagnosisForPrint(this decimal value)
        {
            try
            {
                if (value < 0) return "بد";
                if (value > 0) return "بس";
                return "";
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "";
            }
        }
    }
}
