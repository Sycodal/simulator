//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetRobotModeResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetRobotMode";
        public override string RosMessageName => k_RosMessageName;

        public sbyte robot_mode;
        public bool success;

        public GetRobotModeResponse()
        {
            this.robot_mode = 0;
            this.success = false;
        }

        public GetRobotModeResponse(sbyte robot_mode, bool success)
        {
            this.robot_mode = robot_mode;
            this.success = success;
        }

        public static GetRobotModeResponse Deserialize(MessageDeserializer deserializer) => new GetRobotModeResponse(deserializer);

        private GetRobotModeResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.robot_mode);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.robot_mode);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetRobotModeResponse: " +
            "\nrobot_mode: " + robot_mode.ToString() +
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