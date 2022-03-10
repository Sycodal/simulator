//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetCurrentTcpRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetCurrentTcp";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  get_current_tcp  
        //  It is the service to get the currently set TCP information from the robot controller
        // ____________________________________________________________________________________________

        public GetCurrentTcpRequest()
        {
        }
        public static GetCurrentTcpRequest Deserialize(MessageDeserializer deserializer) => new GetCurrentTcpRequest(deserializer);

        private GetCurrentTcpRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "GetCurrentTcpRequest: ";
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
