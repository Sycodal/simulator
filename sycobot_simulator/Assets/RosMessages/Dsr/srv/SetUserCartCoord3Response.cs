//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetUserCartCoord3Response : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetUserCartCoord3";
        public override string RosMessageName => k_RosMessageName;

        public sbyte id;
        //  set user coord (101~120) or fail(-1) 
        public bool success;

        public SetUserCartCoord3Response()
        {
            this.id = 0;
            this.success = false;
        }

        public SetUserCartCoord3Response(sbyte id, bool success)
        {
            this.id = id;
            this.success = success;
        }

        public static SetUserCartCoord3Response Deserialize(MessageDeserializer deserializer) => new SetUserCartCoord3Response(deserializer);

        private SetUserCartCoord3Response(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.id);
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.id);
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "SetUserCartCoord3Response: " +
            "\nid: " + id.ToString() +
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