//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class DrlPauseRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/DrlPause";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  drl_script_pause  
        //  This service is used to stop the currently executing DRL program from the robot controller.
        // ____________________________________________________________________________________________

        public DrlPauseRequest()
        {
        }
        public static DrlPauseRequest Deserialize(MessageDeserializer deserializer) => new DrlPauseRequest(deserializer);

        private DrlPauseRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "DrlPauseRequest: ";
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