//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetDesiredVelxResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetDesiredVelx";
        public override string RosMessageName => k_RosMessageName;

        public double[] vel;
        //  Tool velocity
        public bool success;

        public GetDesiredVelxResponse()
        {
            this.vel = new double[6];
            this.success = false;
        }

        public GetDesiredVelxResponse(double[] vel, bool success)
        {
            this.vel = vel;
            this.success = success;
        }

        public static GetDesiredVelxResponse Deserialize(MessageDeserializer deserializer) => new GetDesiredVelxResponse(deserializer);

        private GetDesiredVelxResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.vel, sizeof(double), 6);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.vel);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GetDesiredVelxResponse: " +
            "\nvel: " + System.String.Join(", ", vel.ToList()) +
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