//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class Robotiq2FOpenResponse : Message
    {
        public const string k_RosMessageName = "dsr_msgs/Robotiq2FOpen";
        public override string RosMessageName => k_RosMessageName;

        public bool success;

        public Robotiq2FOpenResponse()
        {
            this.success = false;
        }

        public Robotiq2FOpenResponse(bool success)
        {
            this.success = success;
        }

        public static Robotiq2FOpenResponse Deserialize(MessageDeserializer deserializer) => new Robotiq2FOpenResponse(deserializer);

        private Robotiq2FOpenResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "Robotiq2FOpenResponse: " +
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
