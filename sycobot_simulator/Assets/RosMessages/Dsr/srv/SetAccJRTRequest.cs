//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetAccJRTRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetAccJRT";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  set_accj_rt
        // ____________________________________________________________________________________________
        public double[] acc;

        public SetAccJRTRequest()
        {
            this.acc = new double[6];
        }

        public SetAccJRTRequest(double[] acc)
        {
            this.acc = acc;
        }

        public static SetAccJRTRequest Deserialize(MessageDeserializer deserializer) => new SetAccJRTRequest(deserializer);

        private SetAccJRTRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.acc, sizeof(double), 6);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.acc);
        }

        public override string ToString()
        {
            return "SetAccJRTRequest: " +
            "\nacc: " + System.String.Join(", ", acc.ToList());
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
