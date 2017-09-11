using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AgencyApp.Models;

namespace AgencyApp.Services
{
    class GeneralService
    {
        /// <summary>
        /// Gets the todo items async.
        /// </summary>
        /// <returns>The todo items async.</returns>
        public async Task<bool> LoginUser(string clientId, string ssn)
        {
            bool IsAuth = false;
            try
            {
                string retObj;
                HttpClient client = new HttpClient();
                string url = "http://cccsrochester.speridian.com/FinancialCoachApiforApp/api/WebApi/GetClientInfo?ClientID=" + clientId + "&SSN=" + ssn;
                string response = await client.GetStringAsync(url);

                retObj = JsonConvert.DeserializeObject<string>(response.ToString());

                if (retObj == "Success")
                    IsAuth = true;

            }
            catch (Exception ex)
            {
                IsAuth = false;
            }
            return IsAuth;
        }

        /// <summary>
        /// Gets the todo items async.
        /// </summary>
        /// <returns>The todo items async.</returns>
        public async Task<List<ActionItem>> GetMyActionPlan(string clientId)
        {
            List<ActionItem> actionItems = new List<ActionItem>();
            try
            {
                string retObj;
                HttpClient client = new HttpClient();
                string url = "http://cccsrochester.speridian.com/FinancialCoachApiforApp/api/WebApi/GetMyClientActionPlan?clientID=" + clientId;
                var response = await client.GetStringAsync(url);
                retObj = JsonConvert.DeserializeObject<string>(response);

                JObject o = JObject.Parse(retObj);
                JArray a = (JArray)o["QueueDetails"]["Table"];
                actionItems = a.ToObject<List<ActionItem>>();

            }
            catch (Exception ex)
            {
                actionItems = null;
            }
            return actionItems;
        }

        /// <summary>
        /// Gets the todo items async.
        /// </summary>
        /// <returns>The todo items async.</returns>
        public async Task<List<Recommendations>> GetRecommendations(string clientId)
        {
            List<Recommendations> recommendations = new List<Recommendations>();
            try
            {
                string retObj;
                HttpClient client = new HttpClient();
                string url = "http://cccsrochester.speridian.com/FinancialCoachApiforApp/api/WebApi/GetMyClientActionPlan?clientID=" + clientId;
                var response = await client.GetStringAsync(url);
                retObj = JsonConvert.DeserializeObject<string>(response);

                JObject o = JObject.Parse(retObj);
                JArray a = (JArray)o["QueueDetails"]["Table1"];
                recommendations = a.ToObject<List<Recommendations>>();

            }
            catch (Exception ex)
            {
                recommendations = null;
            }
            return recommendations;
        }

        /// <summary>
        /// Gets the todo items async.
        /// </summary>
        /// <returns>The todo items async.</returns>
        public async Task<List<CreditorList>> GetCreditorDetails(string clientId)
        {
            List<CreditorList> actionItems = new List<CreditorList>();
            try
            {
                string retObj;
                HttpClient client = new HttpClient();
                string url = "http://cccsrochester.speridian.com/FinancialCoachApiforApp/api/WebApi/GetDMPProgress?ClientID=" + clientId;
                var response = await client.GetStringAsync(url);
                retObj = JsonConvert.DeserializeObject<string>(response);


                JObject o = JObject.Parse(retObj);
                JArray a = (JArray)o["QueueDetails"];
                actionItems = a.ToObject<List<CreditorList>>();

            }
            catch (Exception ex)
            {
                actionItems = null;
            }
            return actionItems;
        }

        /// <summary>
        /// Gets the todo items async.
        /// </summary>
        /// <returns>The todo items async.</returns>
        public async Task<List<Articles>> GetArticles(string username)
        {
            List<Articles> actionItems = new List<Articles>();
            try
            {
                string retObj;
                HttpClient client = new HttpClient();
                string url = "http://cccsrochester.speridian.com/FinancialCoachApiforApp/api/WebApi/GetArticles?userid=" + username;
                var response = await client.GetStringAsync(url);
                retObj = JsonConvert.DeserializeObject<string>(response);


                JObject o = JObject.Parse(retObj);
                JArray a = (JArray)o["Articles"];
                actionItems = a.ToObject<List<Articles>>();

            }
            catch (Exception ex)
            {
                actionItems = null;
            }
            return actionItems;
        }

        /// <summary>
        /// Gets the todo items async.
        /// </summary>
        /// <returns>The todo items async.</returns>
        public async Task<List<Video>> GetVideos(string username)
        {
            List<Video> actionItems = new List<Video>();
            try
            {
                string retObj;
                HttpClient client = new HttpClient();
                string url = "http://cccsrochester.speridian.com/FinancialCoachApiforApp/api/WebApi/GetVideos?userid=" + username;
                var response = await client.GetStringAsync(url);
                retObj = JsonConvert.DeserializeObject<string>(response);


                JObject o = JObject.Parse(retObj);
                JArray a = (JArray)o["Videos"];
                actionItems = a.ToObject<List<Video>>();

            }
            catch (Exception ex)
            {
                actionItems = null;
            }
            return actionItems;
        }

        /// <summary>
        /// Gets the todo items async.
        /// </summary>
        /// <returns>The todo items async.</returns>
        public async Task<List<NotificationItem>> GetNotificationList(string clientId)
        {
            List<NotificationItem> actionItems = new List<NotificationItem>();
            try
            {
                string retObj;
                HttpClient client = new HttpClient();
                string url = "http://cccsrochester.speridian.com/FinancialCoachApiforApp/api/WebApi/GetNotification?ClientID=" + clientId;
                var response = await client.GetStringAsync(url);

                //using (HttpClient httpClient = new HttpClient())
                //{
                //    var response = httpClient.GetAsync(url).GetAwaiter().GetResult();
                //    var result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                //    retObj = JsonConvert.DeserializeObject<string>(result);


                //    JObject o = JObject.Parse(retObj);
                //    JArray a = (JArray)o["Notifications"];
                //    actionItems = a.ToObject<List<NotificationItem>>();
                //}

                retObj = JsonConvert.DeserializeObject<string>(response);


                JObject o = JObject.Parse(retObj);
                JArray a = (JArray)o["Notifications"];
                actionItems = a.ToObject<List<NotificationItem>>();

            }
            catch (Exception ex)
            {
                actionItems = null;
            }
            return actionItems;
        }

        /// <summary>
        /// Gets the notifications async.
        /// </summary>
        /// <returns>The Notifications async.</returns>
        public async Task<List<Notification>> GetNotifications(string clientId)
        {
            List<Notification> notificationItems = new List<Notification>();
            try
            {
                string retObj;
                HttpClient client = new HttpClient();
                string url = "http://cccsrochester.speridian.com/FinancialCoachApiforApp/api/WebApi/GetNotifications?ClientID=" + clientId;
                var response = await client.GetStringAsync(url);
                retObj = JsonConvert.DeserializeObject<string>(response);


                JObject o = JObject.Parse(retObj);
                JArray a = (JArray)o["Notifications"];
                notificationItems = a.ToObject<List<Notification>>();

            }
            catch (Exception ex)
            {
                notificationItems = null;
            }
            return notificationItems;
        }

        public async Task<string> GetContactNummer(string username)
        {
            string contactNumber = "";
            try
            {
                string retObj;
                HttpClient client = new HttpClient();
                string url = "http://cccsrochester.speridian.com/FinancialCoachApiforApp/api/WebApi/GetContactnumber?userid="+ username;
                var response = await client.GetStringAsync(url);
                retObj = JsonConvert.DeserializeObject<string>(response);


                JObject o = JObject.Parse(retObj);
                //JArray a = (JArray)o["Contactnumber"];
                contactNumber = Convert.ToString(o["Contactnumber"]);

            }
            catch (Exception ex)
            {
                contactNumber = null;
            }
            return contactNumber;
        }

    }
}
