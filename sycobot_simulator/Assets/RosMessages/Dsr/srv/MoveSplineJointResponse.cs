//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class MoveSplineJointResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/MoveSplineJoint";
        public override string RosMessageName => k_RosMessageName;

        public bool success;

        public MoveSplineJointResponse()
        {
            this.success = false;
        }

        public MoveSplineJointResponse(bool success)
        {
            this.success = success;
        }

        public static MoveSplineJointResponse Deserialize(MessageDeserializer deserializer) => new MoveSplineJointResponse(deserializer);

        private MoveSplineJointResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "MoveSplineJointResponse: " +
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
