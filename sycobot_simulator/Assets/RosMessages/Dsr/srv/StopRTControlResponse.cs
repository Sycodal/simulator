//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class StopRTControlResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/StopRTControl";
        public override string RosMessageName => k_RosMessageName;

        public bool success;

        public StopRTControlResponse()
        {
            this.success = false;
        }

        public StopRTControlResponse(bool success)
        {
            this.success = success;
        }

        public static StopRTControlResponse Deserialize(MessageDeserializer deserializer) => new StopRTControlResponse(deserializer);

        private StopRTControlResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "StopRTControlResponse: " +
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
