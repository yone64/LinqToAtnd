using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AtndLibrary
{
    public static class AtndWebClient
    {
        private const string BASE_URL = "http://api.atnd.org/eventatnd/event/";

        public static async Task<IEnumerable<hashEvent>> QueryEvent(string queryString)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BASE_URL);

            var response = await client.GetAsync("?" + queryString);
            response.EnsureSuccessStatusCode();
            var str = await response.Content.ReadAsStringAsync();

            // デシリアライズできなかったので。
            var xml = XDocument.Parse(str);

            var q = xml.Descendants("event")
                        .Select(x => new hashEvent
                        {
                            event_id = (string)x.Element("event_id"),
                            title = (string)x.Element("title"),
                            @catch = (string)x.Element("catch"),
                            description = (string)x.Element("description"),
                            event_url = (string)x.Element("event_url"),
                            started_at = (DateTime)x.Element("started_at"),
                            ended_at = (DateTime)x.Element("ended_at"),
                        });

            return q;
        }
    }
}
