//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetRobotSpeedModeResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetRobotSpeedMode";
        public override string RosMessageName => k_RosMessageName;

        public bool success;

        public SetRobotSpeedModeResponse()
        {
            this.success = false;
        }

        public SetRobotSpeedModeResponse(bool success)
        {
            this.success = success;
        }

        public static SetRobotSpeedModeResponse Deserialize(MessageDeserializer deserializer) => new SetRobotSpeedModeResponse(deserializer);

        private SetRobotSpeedModeResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "SetRobotSpeedModeResponse: " +
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
