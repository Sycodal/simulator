//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class ReadDataRTRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/ReadDataRT";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  read_data_rt
        // ____________________________________________________________________________________________

        public ReadDataRTRequest()
        {
        }
        public static ReadDataRTRequest Deserialize(MessageDeserializer deserializer) => new ReadDataRTRequest(deserializer);

        private ReadDataRTRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "ReadDataRTRequest: ";
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
