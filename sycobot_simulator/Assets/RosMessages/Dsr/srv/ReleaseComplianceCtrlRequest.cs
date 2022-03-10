//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class ReleaseComplianceCtrlRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/ReleaseComplianceCtrl";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  release_compliance_ctrl  
        // ____________________________________________________________________________________________

        public ReleaseComplianceCtrlRequest()
        {
        }
        public static ReleaseComplianceCtrlRequest Deserialize(MessageDeserializer deserializer) => new ReleaseComplianceCtrlRequest(deserializer);

        private ReleaseComplianceCtrlRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "ReleaseComplianceCtrlRequest: ";
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