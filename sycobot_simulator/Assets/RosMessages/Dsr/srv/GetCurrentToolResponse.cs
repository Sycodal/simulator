//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetCurrentToolResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetCurrentTool";
        public override string RosMessageName => k_RosMessageName;

        public string info;
        //  tool name
        public bool success;

        public GetCurrentToolResponse()
        {
            this.info = "";
            this.success = false;
        }

        public GetCurrentToolResponse(string info, bool success)
        {
            this.info = info;
            this.success = success;
        }

        public static GetCurrentToolResponse Deserialize(MessageDeserializer deserializer) => new GetCurrentToolResponse(deserializer);

        private GetCurrentToolResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.info);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.info);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetCurrentToolResponse: " +
            "\ninfo: " + info.ToString() +
            "\nsuccess: " + success.ToString();
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