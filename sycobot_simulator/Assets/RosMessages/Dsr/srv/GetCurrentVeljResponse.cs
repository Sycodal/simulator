//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetCurrentVeljResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetCurrentVelj";
        public override string RosMessageName => k_RosMessageName;

        public double[] joint_speed;
        //  joint speed 
        public bool success;

        public GetCurrentVeljResponse()
        {
            this.joint_speed = new double[6];
            this.success = false;
        }

        public GetCurrentVeljResponse(double[] joint_speed, bool success)
        {
            this.joint_speed = joint_speed;
            this.success = success;
        }

        public static GetCurrentVeljResponse Deserialize(MessageDeserializer deserializer) => new GetCurrentVeljResponse(deserializer);

        private GetCurrentVeljResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.joint_speed, sizeof(double), 6);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.joint_speed);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetCurrentVeljResponse: " +
            "\njoint_speed: " + System.String.Join(", ", joint_speed.ToList()) +
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
