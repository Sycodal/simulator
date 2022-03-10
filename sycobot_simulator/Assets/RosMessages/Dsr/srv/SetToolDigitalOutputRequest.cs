//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetToolDigitalOutputRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetToolDigitalOutput";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  set_tool_digital_output  
        //  This service sends ouptput to tool io.
        // ____________________________________________________________________________________________
        public sbyte index;
        //  flange digital output port(1 ~ 6)
        public sbyte value;
        //  0 : ON, 1 : OFF

        public SetToolDigitalOutputRequest()
        {
            this.index = 0;
            this.value = 0;
        }

        public SetToolDigitalOutputRequest(sbyte index, sbyte value)
        {
            this.index = index;
            this.value = value;
        }

        public static SetToolDigitalOutputRequest Deserialize(MessageDeserializer deserializer) => new SetToolDigitalOutputRequest(deserializer);

        private SetToolDigitalOutputRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.index);
            deserializer.Read(out this.value);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.index);
            serializer.Write(this.value);
        }

        public override string ToString()
        {
            return "SetToolDigitalOutputRequest: " +
            "\nindex: " + index.ToString() +
            "\nvalue: " + value.ToString();
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
