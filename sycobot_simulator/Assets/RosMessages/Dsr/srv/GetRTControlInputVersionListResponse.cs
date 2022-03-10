//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetRTControlInputVersionListResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetRTControlInputVersionList";
        public override string RosMessageName => k_RosMessageName;

        public bool success;
        public string version;

        public GetRTControlInputVersionListResponse()
        {
            this.success = false;
            this.version = "";
        }

        public GetRTControlInputVersionListResponse(bool success, string version)
        {
            this.success = success;
            this.version = version;
        }

        public static GetRTControlInputVersionListResponse Deserialize(MessageDeserializer deserializer) => new GetRTControlInputVersionListResponse(deserializer);

        private GetRTControlInputVersionListResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
            deserializer.Read(out this.version);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
            serializer.Write(this.version);
        }

        public override string ToString()
        {
            return "GetRTControlInputVersionListResponse: " +
            "\nsuccess: " + success.ToString() +
            "\nversion: " + version.ToString();
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