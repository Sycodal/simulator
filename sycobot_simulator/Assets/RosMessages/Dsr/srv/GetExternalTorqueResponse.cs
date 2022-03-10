//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetExternalTorqueResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetExternalTorque";
        public override string RosMessageName => k_RosMessageName;

        public double[] ext_torque;
        // Torque value generated by an external force
        public bool success;

        public GetExternalTorqueResponse()
        {
            this.ext_torque = new double[6];
            this.success = false;
        }

        public GetExternalTorqueResponse(double[] ext_torque, bool success)
        {
            this.ext_torque = ext_torque;
            this.success = success;
        }

        public static GetExternalTorqueResponse Deserialize(MessageDeserializer deserializer) => new GetExternalTorqueResponse(deserializer);

        private GetExternalTorqueResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.ext_torque, sizeof(double), 6);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.ext_torque);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetExternalTorqueResponse: " +
            "\next_torque: " + System.String.Join(", ", ext_torque.ToList()) +
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
