using System.Text;

namespace Vinpay.Utils
{
    /// <summary>
    /// A util to operate strings.
    /// </summary>
    public static class StringUtil
    {
        /// <summary>
        /// Convert the byte array to a hexadecimal string
        /// </summary>
        /// <param name="data">The input byte array.</param>
        /// <param name="separator">The separator between each byte.</param>
        /// <param name="isLowerCase">Indicates whether the MD5 string is in lowercase</param>
        /// <returns></returns>
        public static string BytesToHexString(this byte[] data, string separator = "", bool isLowerCase = true)
        {
            StringBuilder sb = new StringBuilder();
            string format = isLowerCase ? "x2" : "X2";
            bool useSeparator = !string.IsNullOrEmpty(separator);

            if (useSeparator)
            {
                for (int i = 0; i < data.Length - 1; i++)
                {
                    sb.Append(data[i].ToString(format));
                    sb.Append(separator);
                }
                sb.Append(data[data.Length - 1].ToString(format));
            }
            else
            {
                for (int i = 0; i < data.Length; i++)
                {

                    sb.Append(data[i].ToString(format));
                }
            }

            return sb.ToString();
        }
    }
}
