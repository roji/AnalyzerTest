using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Core.Tools.JsonConvertors
{

   public class StringToInt32 : JsonConverter<int>
   {
      public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
         if (reader.TokenType == JsonTokenType.String)
            return int.Parse(reader.GetString());
         else if (reader.TokenType == JsonTokenType.Number)
            return reader.GetInt32();
         else
            throw new Exception($"StringToInt32 Convertor not support {reader.TokenType}");
      }

      public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
      {
         writer.WriteNumberValue(value);
      }

   }
}
