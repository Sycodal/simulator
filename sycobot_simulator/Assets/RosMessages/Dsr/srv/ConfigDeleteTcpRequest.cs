//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class ConfigDeleteTcpRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/ConfigDeleteTcp";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  config_delete_tcp  
        //  It is a service for deleting the TCP information registered in advance in the robot controller
        // ____________________________________________________________________________________________
        public string name;
        //  tcp name 

        public ConfigDeleteTcpRequest()
        {
            this.name = "";
        }

        public ConfigDeleteTcpRequest(string name)
        {
            this.name = name;
        }

        public static ConfigDeleteTcpRequest Deserialize(MessageDeserializer deserializer) => new ConfigDeleteTcpRequest(deserializer);

        private ConfigDeleteTcpRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.name);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.name);
        }

        public override string ToString()
        {
            return "ConfigDeleteTcpRequest: " +
            "\nname: " + name.ToString();
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
