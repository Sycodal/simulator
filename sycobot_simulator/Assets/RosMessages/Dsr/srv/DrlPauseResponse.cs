//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class DrlPauseResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/DrlPause";
        public override string RosMessageName => k_RosMessageName;

        public bool success;

        public DrlPauseResponse()
        {
            this.success = false;
        }

        public DrlPauseResponse(bool success)
        {
            this.success = success;
        }

        public static DrlPauseResponse Deserialize(MessageDeserializer deserializer) => new DrlPauseResponse(deserializer);

        private DrlPauseResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "DrlPauseResponse: " +
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
