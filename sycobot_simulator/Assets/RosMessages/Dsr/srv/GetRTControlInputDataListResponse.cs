//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetRTControlInputDataListResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetRTControlInputDataList";
        public override string RosMessageName => k_RosMessageName;

        public bool success;
        public string data;

        public GetRTControlInputDataListResponse()
        {
            this.success = false;
            this.data = "";
        }

        public GetRTControlInputDataListResponse(bool success, string data)
        {
            this.success = success;
            this.data = data;
        }

        public static GetRTControlInputDataListResponse Deserialize(MessageDeserializer deserializer) => new GetRTControlInputDataListResponse(deserializer);

        private GetRTControlInputDataListResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
            deserializer.Read(out this.data);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
            serializer.Write(this.data);
        }

        public override string ToString()
        {
            return "GetRTControlInputDataListResponse: " +
            "\nsuccess: " + success.ToString() +
            "\ndata: " + data.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Response);
        }
    }
}
