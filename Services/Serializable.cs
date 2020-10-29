using System;
using System.Threading;
using Newtonsoft.Json;

namespace Services
{
    public class Serializable<T>
    {
        public static T FromString(string data)
        {
            return data.FromJson<T>();
        }

        public virtual string ToString(Formatting formatting = Formatting.None)
        {
            try
            {
                return Json.ToStringJson(this, formatting);
            }
            catch (OperationCanceledException) { return ""; }
            catch (ThreadAbortException) { return ""; }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "";
            }
        }

        public override string ToString()
        {
            return Json.ToStringJson(this);
        }

        public virtual string ToString(JsonConverter converter)
        {
            return Json.ToStringJson(this, converter);
        }
    }
}
