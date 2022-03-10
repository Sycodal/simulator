//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class ParallelAxis1Response : Message
    {
        public const string k_RosMessageName = "dsr_msgs/ParallelAxis1";
        public override string RosMessageName => k_RosMessageName;

        public bool success;

        public ParallelAxis1Response()
        {
            this.success = false;
        }

        public ParallelAxis1Response(bool success)
        {
            this.success = success;
        }

        public static ParallelAxis1Response Deserialize(MessageDeserializer deserializer) => new ParallelAxis1Response(deserializer);

        private ParallelAxis1Response(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "ParallelAxis1Response: " +
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