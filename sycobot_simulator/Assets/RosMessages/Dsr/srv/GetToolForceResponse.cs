//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetToolForceResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetToolForce";
        public override string RosMessageName => k_RosMessageName;

        public double[] tool_force;
        //  External force applied to the tool
        public bool success;

        public GetToolForceResponse()
        {
            this.tool_force = new double[6];
            this.success = false;
        }

        public GetToolForceResponse(double[] tool_force, bool success)
        {
            this.tool_force = tool_force;
            this.success = success;
        }

        public static GetToolForceResponse Deserialize(MessageDeserializer deserializer) => new GetToolForceResponse(deserializer);

        private GetToolForceResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.tool_force, sizeof(double), 6);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.tool_force);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetToolForceResponse: " +
            "\ntool_force: " + System.String.Join(", ", tool_force.ToList()) +
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
