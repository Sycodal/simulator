//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class GetJointTorqueRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/GetJointTorque";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  get_joint_torque()
        //  returns the sensor torque value of the current joint.
        // ____________________________________________________________________________________________
        //  This service returns the sensor torque value of the current joint.

        public GetJointTorqueRequest()
        {
        }
        public static GetJointTorqueRequest Deserialize(MessageDeserializer deserializer) => new GetJointTorqueRequest(deserializer);

        private GetJointTorqueRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "GetJointTorqueRequest: ";
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
