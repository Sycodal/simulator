//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetJointTorqueResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetJointTorque";
        public override string RosMessageName => k_RosMessageName;

        public double[] jts;
        //  value of JTS(Joint Torque Sensor) 
        public bool success;

        public GetJointTorqueResponse()
        {
            this.jts = new double[6];
            this.success = false;
        }

        public GetJointTorqueResponse(double[] jts, bool success)
        {
            this.jts = jts;
            this.success = success;
        }

        public static GetJointTorqueResponse Deserialize(MessageDeserializer deserializer) => new GetJointTorqueResponse(deserializer);

        private GetJointTorqueResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.jts, sizeof(double), 6);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.jts);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetJointTorqueResponse: " +
            "\njts: " + System.String.Join(", ", jts.ToList()) +
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