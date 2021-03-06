//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class MoveResumeRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/MoveResume";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  motion pause
        // ____________________________________________________________________________________________

        public MoveResumeRequest()
        {
        }
        public static MoveResumeRequest Deserialize(MessageDeserializer deserializer) => new MoveResumeRequest(deserializer);

        private MoveResumeRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "MoveResumeRequest: ";
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
