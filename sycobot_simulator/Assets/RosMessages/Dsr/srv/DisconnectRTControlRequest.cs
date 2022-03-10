//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class DisconnectRTControlRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/DisconnectRTControl";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  disconnect_rt_control
        // ____________________________________________________________________________________________

        public DisconnectRTControlRequest()
        {
        }
        public static DisconnectRTControlRequest Deserialize(MessageDeserializer deserializer) => new DisconnectRTControlRequest(deserializer);

        private DisconnectRTControlRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "DisconnectRTControlRequest: ";
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
