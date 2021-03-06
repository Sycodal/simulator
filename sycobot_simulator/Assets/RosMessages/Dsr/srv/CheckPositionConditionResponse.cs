//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class CheckPositionConditionResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/CheckPositionCondition";
        public override string RosMessageName => k_RosMessageName;

        public bool success;
        //  True or False

        public CheckPositionConditionResponse()
        {
            this.success = false;
        }

        public CheckPositionConditionResponse(bool success)
        {
            this.success = success;
        }

        public static CheckPositionConditionResponse Deserialize(MessageDeserializer deserializer) => new CheckPositionConditionResponse(deserializer);

        private CheckPositionConditionResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "CheckPositionConditionResponse: " +
            "\nsuccess: " + success.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Response);
        }
    }
}
