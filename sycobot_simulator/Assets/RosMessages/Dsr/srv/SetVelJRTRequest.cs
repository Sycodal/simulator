//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetVelJRTRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetVelJRT";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  set_velj_rt
        // ____________________________________________________________________________________________
        public double[] vel;

        public SetVelJRTRequest()
        {
            this.vel = new double[6];
        }

        public SetVelJRTRequest(double[] vel)
        {
            this.vel = vel;
        }

        public static SetVelJRTRequest Deserialize(MessageDeserializer deserializer) => new SetVelJRTRequest(deserializer);

        private SetVelJRTRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.vel, sizeof(double), 6);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.vel);
        }

        public override string ToString()
        {
            return "SetVelJRTRequest: " +
            "\nvel: " + System.String.Join(", ", vel.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
