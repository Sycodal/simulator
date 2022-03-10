//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class StopRTControlRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/StopRTControl";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  stop_rt_control
        // ____________________________________________________________________________________________

        public StopRTControlRequest()
        {
        }
        public static StopRTControlRequest Deserialize(MessageDeserializer deserializer) => new StopRTControlRequest(deserializer);

        private StopRTControlRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "StopRTControlRequest: ";
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