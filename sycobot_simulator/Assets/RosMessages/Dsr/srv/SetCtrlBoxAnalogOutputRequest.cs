//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetCtrlBoxAnalogOutputRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetCtrlBoxAnalogOutput";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  set_ctrl_box_analog_output  
        // ____________________________________________________________________________________________
        public sbyte channel;
        //  1 = ch1, 2= ch2 
        public double value;
        // 

        public SetCtrlBoxAnalogOutputRequest()
        {
            this.channel = 0;
            this.value = 0.0;
        }

        public SetCtrlBoxAnalogOutputRequest(sbyte channel, double value)
        {
            this.channel = channel;
            this.value = value;
        }

        public static SetCtrlBoxAnalogOutputRequest Deserialize(MessageDeserializer deserializer) => new SetCtrlBoxAnalogOutputRequest(deserializer);

        private SetCtrlBoxAnalogOutputRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.channel);
            deserializer.Read(out this.value);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.channel);
            serializer.Write(this.value);
        }

        public override string ToString()
        {
            return "SetCtrlBoxAnalogOutputRequest: " +
            "\nchannel: " + channel.ToString() +
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
