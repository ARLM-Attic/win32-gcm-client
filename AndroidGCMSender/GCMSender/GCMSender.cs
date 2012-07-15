using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace GCMSender
{
    public class GCMSender
    {
        private const string GCM_URI = "https://android.googleapis.com/gcm/send";

        #region Properties
        public string DeviceToken { get; set; }
        public string APIKey { get; set; } 
        #endregion

        public GCMSender()
        {
            // do nothing
        }

        public GCMSender(string deviceToken, string apiKey)
        {
            DeviceToken = deviceToken;
            APIKey = apiKey;
        }

        public string Send(string message)
        {


            return null;
        }

        private string AssembleJSONPayload(string gcmDeviceToken, string gcmBody)
        {
            string payloadFormat =
                "{{" +
                    "\"registration_ids\" : [\"{0}\"]," +
                    "\"data\" : {{" +
                        " {1} " +
                    "}}" +
                "}}";

            string payload = string.Format(payloadFormat, gcmDeviceToken, gcmBody);
            Debug.WriteLine("payload : " + payload);

            return payload;
        }
    }
}
