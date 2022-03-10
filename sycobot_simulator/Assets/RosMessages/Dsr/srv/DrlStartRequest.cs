//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class DrlStartRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/DrlStart";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  drl_script_run  
        //  This is a service to execute a program configured in the DRL language in the robot controller.
        // ____________________________________________________________________________________________
        public sbyte robotSystem;
        //  Robot System Mode 0 : Real, 1 : virtual
        public string code;
        //  drl code       

        public DrlStartRequest()
        {
            this.robotSystem = 0;
            this.code = "";
        }

        public DrlStartRequest(sbyte robotSystem, string code)
        {
            this.robotSystem = robotSystem;
            this.code = code;
        }

        public static DrlStartRequest Deserialize(MessageDeserializer deserializer) => new DrlStartRequest(deserializer);

        private DrlStartRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.robotSystem);
            deserializer.Read(out this.code);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.robotSystem);
            serializer.Write(this.code);
        }

        public override string ToString()
        {
            return "DrlStartRequest: " +
            "\nrobotSystem: " + robotSystem.ToString() +
            "\ncode: " + code.ToString();
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
