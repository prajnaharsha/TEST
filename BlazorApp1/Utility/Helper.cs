using Newtonsoft.Json;

namespace LitHold.Utility
{
    /// <summary>
    /// Provides helper methods for various tasks.
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Converts a file size in bytes to a human-readable string representation.
        /// </summary>
        /// <param name="fileSizeInBytes">The file size in bytes to convert.</param>
        /// <returns>A string representing the file size in a human-readable format.</returns>
        public static string ConvertFileSize(long fileSizeInBytes)
        {
            int kiloByte = 1024;
            int megaByte = 1024 * kiloByte;

            if (fileSizeInBytes < kiloByte)
            {
                return $"{fileSizeInBytes} B";
            }
            else if (fileSizeInBytes < megaByte)
            {
                double sizeInKB = (double)fileSizeInBytes / kiloByte;
                return $"{sizeInKB:N2} KB";
            }
            else
            {
                double sizeInMB = (double)fileSizeInBytes / megaByte;
                return $"{sizeInMB:N2} MB";
            }
        }

        /// <summary>
        /// Serializes the specified object into a JSON string.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize.</typeparam>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>A JSON string representing the serialized object.</returns>
        public static string SerializeObject<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented)
                                 .Replace("{", "\n{");

        }
    }
}
