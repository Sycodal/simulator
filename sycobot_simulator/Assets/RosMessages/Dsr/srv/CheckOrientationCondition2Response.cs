//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class CheckOrientationCondition2Response : Message
    {
        public const string k_RosMessageName = "dsr_msgs/CheckOrientationCondition2";
        public override string RosMessageName => k_RosMessageName;

        public bool success;
        //  True or False

        public CheckOrientationCondition2Response()
        {
            this.success = false;
        }

        public CheckOrientationCondition2Response(bool success)
        {
            this.success = success;
        }

        public static CheckOrientationCondition2Response Deserialize(MessageDeserializer deserializer) => new CheckOrientationCondition2Response(deserializer);

        private CheckOrientationCondition2Response(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "CheckOrientationCondition2Response: " +
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
