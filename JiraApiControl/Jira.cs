using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JiraApiControl
{
    class Jira
    {
        const string QUERY_URL_FORMAT = "https://{0}/jira/rest/api/2/{1}";
        // https://jira.rakuten-it.com/jira/rest/api/2/

        string _baseUrl;
        CookieContainer _cookies;
        HttpClient _httpClient;

        public async Task<bool> Login(string jiraServer, string userId, string password)
        {
            string url = string.Format(QUERY_URL_FORMAT, jiraServer, "myself");
            string authHeader = CreateBasicAuth(userId, password);

            HttpClientHandler handler = new HttpClientHandler();
            _cookies = new CookieContainer();
            handler.CookieContainer = _cookies;

            HttpClient hc = new HttpClient(handler);

            hc.DefaultRequestHeaders.Add("Authorization", authHeader);

            HttpResponseMessage hrm = await hc.GetAsync(url);
            if (hrm.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return false;
            }

            _baseUrl = string.Format(QUERY_URL_FORMAT, jiraServer, "");
            _httpClient = hc;

            return true;
        }

        private string CreateBasicAuth(string userId, string password)
        {
            string text = userId + ":" + password;
            byte[] buf = Encoding.UTF8.GetBytes(text);
            return "Basic " + Convert.ToBase64String(buf);
        }

        public async Task<SearchResult> GetIssuesByAssignee(string assignee)
        {
            string url = _baseUrl + "search?jql=status != Closed and duedate < 2d and assignee= " + assignee;

            HttpResponseMessage hrm = await _httpClient.GetAsync(url);

            string text = await hrm.Content.ReadAsStringAsync();

            SearchResult result = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(text);
            return result;
        }

        public async Task<SearchResult> GetIssuesByAssignee(string projectKey, string assignee)
        {
            string url = _baseUrl + "search?jql=assignee=" + assignee + " and project=" + projectKey + " and status != Close and duedate < 2d";

            HttpResponseMessage hrm = await _httpClient.GetAsync(url);

            string text = await hrm.Content.ReadAsStringAsync();

            SearchResult result = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(text);
            return result;
        }

        /// <summary>
        /// 複合的な自由検索
        /// </summary>
        /// <param name="date"></param>
        /// <param name="fixversion"></param>
        /// <param name="assignee"></param>
        /// <returns></returns>
        public async Task<SearchResult> GetIssuesByAssignee(string date, string fixversion, string assignee, string labels, int startAt, bool doneJudge)
        {
            string url = _baseUrl + "search?jql=duedate < " + date + "d and assignee in (" + assignee + ")";
            //string url2 = " and labels = Racuos_Agile and project = RACUOS and fixVersion in (" + fixversion + ")";

            string url2 = 0.Equals(startAt) ?
                string.Empty : " and startAt = " + startAt.ToString();

            url2 = !string.IsNullOrEmpty(fixversion) ?
                " and fixVersion in (" + fixversion + ")" : string.Empty;

            if (!string.IsNullOrEmpty(labels))
            {
                url2 += " and labels in (" + labels + ")";
            }

            string url3 = " and status not in (Closed,Resolved)";
            string url4 = " and status in (Closed,Resolved)";

            HttpResponseMessage hrm = doneJudge ? await _httpClient.GetAsync(url + url2 + url3) : await _httpClient.GetAsync(url + url2 + url4);

            //string text = await hrm.Content.ReadAsStringAsync();
            SearchResult result = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(await hrm.Content.ReadAsStringAsync());
            return result;
        }
    }
}
