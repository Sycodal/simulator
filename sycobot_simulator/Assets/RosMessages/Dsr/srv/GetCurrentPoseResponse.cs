//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetCurrentPoseResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetCurrentPose";
        public override string RosMessageName => k_RosMessageName;

        public double[] pos;
        public bool success;

        public GetCurrentPoseResponse()
        {
            this.pos = new double[6];
            this.success = false;
        }

        public GetCurrentPoseResponse(double[] pos, bool success)
        {
            this.pos = pos;
            this.success = success;
        }

        public static GetCurrentPoseResponse Deserialize(MessageDeserializer deserializer) => new GetCurrentPoseResponse(deserializer);

        private GetCurrentPoseResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.pos, sizeof(double), 6);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.pos);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetCurrentPoseResponse: " +
            "\npos: " + System.String.Join(", ", pos.ToList()) +
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
