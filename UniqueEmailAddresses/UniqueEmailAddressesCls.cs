using System.Collections.Generic;

namespace UniqueEmailAddresses
{
    public class UniqueEmailAddressesCls
    {
        public int NumUniqueEmails(string[] emails)
        {
            var dic = new Dictionary<string, HashSet<string>>();

            foreach (var email in emails)
            {

                var local = email.Split('@')[0];

                var domain = email.Split('@')[1];

                if (local.Contains("+"))
                {
                    local = local.Split('+')[0];
                }

                local = local.Replace(".", "");

                if (dic.ContainsKey(domain))
                {
                    var value = dic[domain];
                    value.Add(local);
                }
                else
                {
                    var set = new HashSet<string> { local };
                    dic.Add(domain, set);
                }
            }

            var count = 0;

            foreach (var item in dic)
            {
                count += item.Value.Count;
            }

            return count;
        }
    }
}
