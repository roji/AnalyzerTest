using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Core.Tools.JsonConvertors
{

    public class StringToDouble : JsonConverter<double>
    {
        public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
                return Convert.ToDouble(reader.GetString());
            else if (reader.TokenType == JsonTokenType.Number)
                return reader.GetDouble();
            else
                throw new Exception($"StringtoDouble Convertor not support {reader.TokenType}");
        }

        public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }

    }
}