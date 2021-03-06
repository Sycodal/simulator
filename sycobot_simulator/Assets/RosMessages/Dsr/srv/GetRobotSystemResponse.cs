//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetRobotSystemResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetRobotSystem";
        public override string RosMessageName => k_RosMessageName;

        public sbyte robot_system;
        //  0 : ROBOT_SYSTEM_REAL
        //  1 : ROBOT_SYSTEM_VIRTUAL
        public bool success;

        public GetRobotSystemResponse()
        {
            this.robot_system = 0;
            this.success = false;
        }

        public GetRobotSystemResponse(sbyte robot_system, bool success)
        {
            this.robot_system = robot_system;
            this.success = success;
        }

        public static GetRobotSystemResponse Deserialize(MessageDeserializer deserializer) => new GetRobotSystemResponse(deserializer);

        private GetRobotSystemResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.robot_system);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.robot_system);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetRobotSystemResponse: " +
            "\nrobot_system: " + robot_system.ToString() +
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
