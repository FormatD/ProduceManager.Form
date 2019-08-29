using Newtonsoft.Json;

namespace ProduceManager.Core.Utils
{
    public static class ObjectExtension
    {
        public static string ToJson<T>(this T source)
        {
            return JsonConvert.SerializeObject(source);
        }

        public static T FromJson<T>(this string source)
        {
            return JsonConvert.DeserializeObject<T>(source);
        }
    }
}
