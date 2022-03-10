//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetRTControlOutputDataListResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetRTControlOutputDataList";
        public override string RosMessageName => k_RosMessageName;

        public bool success;
        public string data;

        public GetRTControlOutputDataListResponse()
        {
            this.success = false;
            this.data = "";
        }

        public GetRTControlOutputDataListResponse(bool success, string data)
        {
            this.success = success;
            this.data = data;
        }

        public static GetRTControlOutputDataListResponse Deserialize(MessageDeserializer deserializer) => new GetRTControlOutputDataListResponse(deserializer);

        private GetRTControlOutputDataListResponse(MessageDeserializer deserializer)
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
            return "GetRTControlOutputDataListResponse: " +
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
