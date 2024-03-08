using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LitHold.Utility
{
    /// <summary>
    /// Custom JSON date format converter.
    /// </summary>
    public class DateFormatConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateFormatConverter"/> class with the specified date format.
        /// </summary>
        /// <param name="format">The date format string.</param>
        public DateFormatConverter(string format)
        {
            DateTimeFormat = format;
        }
        /// <summary>
        /// Writes JSON data to the specified JSON writer.
        /// </summary>
        /// <param name="writer">The JSON writer to which to write the JSON data.</param>
        /// <param name="value">The value to be written as JSON.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteValue(string.Empty);
            }
            else
            {
                base.WriteJson(writer, value, serializer);
            }
        }
    }
    /// <summary>
    /// Converts null values to empty strings during JSON serialization.
    /// </summary>
    public class NullToEmptyStringConverter : Newtonsoft.Json.JsonConverter
    {
        /// <summary>
        /// Determines whether this converter can convert the specified object type.
        /// </summary>
        /// <param name="objectType">The type of the object to convert.</param>
        /// <returns>True if this converter can convert the specified object type; otherwise, false.</returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        /// <summary>
        /// Reads JSON data from the specified JSON reader and converts it to the specified object type.
        /// </summary>
        /// <param name="reader">The JSON reader from which to read the JSON data.</param>
        /// <param name="objectType">The type of the object to convert to.</param>
        /// <param name="existingValue">The existing value of the object being read.</param>
        /// <param name="serializer">The JSON serializer.</param>
        /// <returns>The converted object.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Writes JSON data to the specified JSON writer.
        /// </summary>
        /// <param name="writer">The JSON writer to which to write the JSON data.</param>
        /// <param name="value">The value to be written as JSON.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            writer.WriteValue(value ?? string.Empty);
        }
    }

    /// <summary>
    /// Custom JSON converter for boolean values.
    /// </summary>
    public class CustomBooleanConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool);
        }

        /// <summary>
        /// Writes JSON data to the specified JSON writer.
        /// </summary>
        /// <param name="writer">The JSON writer to which to write the JSON data.</param>
        /// <param name="value">The value to be written as JSON.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {

            bool boolValue = (bool)(value??false);
            string text = boolValue ? "Yes" : "No";
            writer.WriteValue(text);
        }
        /// <summary>
        /// Reads JSON data from the specified JSON reader and converts it to the specified object type.
        /// </summary>
        /// <param name="reader">The JSON reader from which to read the JSON data.</param>
        /// <param name="objectType">The type of the object to convert to.</param>
        /// <param name="existingValue">The existing value of the object being read.</param>
        /// <param name="serializer">The JSON serializer.</param>
        /// <returns>The converted object.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

}


