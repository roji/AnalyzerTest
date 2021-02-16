using System.Text.Json;
using Core.Tools.JsonConvertors;

namespace Core
{
   public static class SerializerHelper
   {
      public static T Deserialize<T>(string value) =>
         JsonSerializer.Deserialize<T>(value, GetJsonSerializerDefaultOptions());

      public static string Serialize<T>(T property) =>
         JsonSerializer.Serialize<T>(property, GetJsonSerializerDefaultOptions());

      private static JsonSerializerOptions GetJsonSerializerDefaultOptions()
      {
         var jsonSerializerOptions = new JsonSerializerOptions();
         jsonSerializerOptions.Converters.Add(new StringToNullableInt32());
         jsonSerializerOptions.Converters.Add(new StringToInt32());
         jsonSerializerOptions.Converters.Add(new StringToDouble());
         jsonSerializerOptions.Converters.Add(new StringToNullableDouble());
         jsonSerializerOptions.PropertyNameCaseInsensitive = true;
         jsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
         return jsonSerializerOptions;
      }
   }
}
