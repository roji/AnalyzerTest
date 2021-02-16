using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Core.Tools.JsonConvertors
{
    public class StringToNullableDouble : JsonConverter<Nullable<double>>
    {
        public override Nullable<double> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
                return ConvertToNullableDouble(reader.GetString());
            else if (reader.TokenType == JsonTokenType.Number)
                return reader.GetDouble();
            else if (reader.TokenType == JsonTokenType.Null)
                return null;
            else
                throw new Exception($"StringToNullableDouble Convertor not support {reader.TokenType}");
        }

        public override void Write(Utf8JsonWriter writer, Nullable<double> value, JsonSerializerOptions options)
        {
            if (value == null)
                writer.WriteNullValue();
            else
                writer.WriteNumberValue(value.Value);
        }

        private double? ConvertToNullableDouble(string s)
        {
            double i;
            if (double.TryParse(s, out i)) return i;
            return null;
        }
    }
}