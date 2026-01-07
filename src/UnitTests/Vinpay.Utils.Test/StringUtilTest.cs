namespace Vinpay.Utils.Test
{
    [TestClass]
    public sealed class StringUtilTest
    {
        [TestMethod]
        [DataRow(new byte[] { 0x35, 0x47, 0xB5, 0x97, 0xCE }, " ", true, "35 47 b5 97 ce")]
        [DataRow(new byte[] { 0x35, 0x47, 0xB5, 0x97, 0xCE }, "", true, "3547b597ce")]
        [DataRow(new byte[] { 0x35, 0x47, 0xB5, 0x97, 0xCE }, "-", true, "35-47-b5-97-ce")]
        [DataRow(new byte[] { 0x35, 0x47, 0xB5, 0x97, 0xCE }, " 0x", true, "35 0x47 0xb5 0x97 0xce")]
        [DataRow(new byte[] { 0x35, 0x47, 0xB5, 0x97, 0xCE }, " ", false, "35 47 B5 97 CE")]
        [DataRow(new byte[] { 0x35, 0x47, 0xB5, 0x97, 0xCE }, "", false, "3547B597CE")]
        [DataRow(new byte[] { 0x35, 0x47, 0xB5, 0x97, 0xCE }, "-", false, "35-47-B5-97-CE")]
        [DataRow(new byte[] { 0x35, 0x47, 0xB5, 0x97, 0xCE }, " 0x", false, "35 0x47 0xB5 0x97 0xCE")]
        [DataRow(new byte[] { 53, 71, 181, 151, 206 }, " ", true, "35 47 b5 97 ce")]
        [DataRow(new byte[] { 53, 71, 181, 151, 206 }, " ", false, "35 47 B5 97 CE")]
        public void BytesToHexStringTest(byte[] data, string separator, bool isLowerCase, string result)
        {
            string output = data.BytesToHexString(separator, isLowerCase);
            Assert.AreEqual(result, output);
        }
    }
}
