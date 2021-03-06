//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetRobotModeResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetRobotMode";
        public override string RosMessageName => k_RosMessageName;

        public bool success;

        public SetRobotModeResponse()
        {
            this.success = false;
        }

        public SetRobotModeResponse(bool success)
        {
            this.success = success;
        }

        public static SetRobotModeResponse Deserialize(MessageDeserializer deserializer) => new SetRobotModeResponse(deserializer);

        private SetRobotModeResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "SetRobotModeResponse: " +
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
