//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class Robotiq2FOpenRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/Robotiq2FOpen";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  robotiq_2f_open
        //  open the virtual robotiq gripper  
        // ____________________________________________________________________________________________
        //  None  

        public Robotiq2FOpenRequest()
        {
        }
        public static Robotiq2FOpenRequest Deserialize(MessageDeserializer deserializer) => new Robotiq2FOpenRequest(deserializer);

        private Robotiq2FOpenRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "Robotiq2FOpenRequest: ";
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