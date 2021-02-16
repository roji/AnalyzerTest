using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Core.Tools.JsonConvertors
{
    public class StringToNullableInt32 : JsonConverter<Nullable<System.Int32>>
    {
        public override Nullable<int> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
                return ConvertToNullableInt(reader.GetString());
            else if (reader.TokenType == JsonTokenType.Number)
                return reader.GetInt32();
            else if (reader.TokenType == JsonTokenType.Null)
                return null;
            else
                throw new Exception($"StringToNullableInt32 Convertor not support {reader.TokenType}");
        }

        public override void Write(Utf8JsonWriter writer, Nullable<int> value, JsonSerializerOptions options)
        {
            if (value == null)
                writer.WriteNullValue();
            else
                writer.WriteNumberValue(value.Value);
        }

        private int? ConvertToNullableInt(string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }
    }
}