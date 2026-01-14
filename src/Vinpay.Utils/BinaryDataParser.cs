namespace Vinpay.Utils
{
    /// <summary>
    /// Parse binary data from strings.
    /// </summary>
    public class BinaryDataParser
    {
        /// <summary>
        /// Parse hex string to byte array.
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] ParseHexString(string hexString)
        {
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException("The length of the input hexadecimal string is not an even number.");
            }

            byte[] buffer = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i += 2)
            {
                buffer[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }

            return buffer;
        }

        /// <summary>
        /// Parse hex string to byte array.
        /// </summary>
        /// <param name="hexString">Input hex string</param>
        /// <param name="separator">Separator between each hex byte string.</param>
        /// <returns></returns>
        public static byte[] ParseHexString(string hexString, string separator)
        {
            if (string.IsNullOrEmpty(separator))
            {
                throw new ArgumentNullException(nameof(separator));
            }

            var hexStringArray = hexString.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            byte[] buffer = new byte[hexStringArray.Length];
            for (int i = 0; i < hexStringArray.Length; i++)
            {
                buffer[i] = Convert.ToByte(hexStringArray[i].Trim(), 16);
            }

            return buffer;
        }
    }
}
