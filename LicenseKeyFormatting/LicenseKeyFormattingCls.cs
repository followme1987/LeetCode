using System.Text;

namespace LicenseKeyFormatting
{
    public class LicenseKeyFormattingCls
    {
        public string LicenseKeyFormatting(string S, int K)
        {
            var sb = new StringBuilder(S.ToUpper());
            var newSb = sb.Replace("-", string.Empty);

            for (var i = newSb.Length - 1; i > K - 1; i -= K) newSb = newSb.Insert(i - K + 1, "-");


            return newSb.ToString();
        }
    }
}