//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class Robotiq2FMoveRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/Robotiq2FMove";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  robotiq_2f_move
        //  open or close the virtual robotiq gripper by input value(width)   
        // ____________________________________________________________________________________________
        public double width;
        //  0.0(open) ~ 0.8(close)

        public Robotiq2FMoveRequest()
        {
            this.width = 0.0;
        }

        public Robotiq2FMoveRequest(double width)
        {
            this.width = width;
        }

        public static Robotiq2FMoveRequest Deserialize(MessageDeserializer deserializer) => new Robotiq2FMoveRequest(deserializer);

        private Robotiq2FMoveRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.width);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.width);
        }

        public override string ToString()
        {
            return "Robotiq2FMoveRequest: " +
            "\nwidth: " + width.ToString();
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
