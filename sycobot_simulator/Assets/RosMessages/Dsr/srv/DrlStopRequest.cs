//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class DrlStopRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/DrlStop";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  drl_script_stop  
        //  STOP_TYPE_QUICK_STO = 0
        //  STOP_TYPE_QUICK     = 1
        //  STOP_TYPE_SLOW      = 2
        //  STOP_TYPE_HOLD = STOP_TYPE_EMERGENCY = 3  
        // ____________________________________________________________________________________________
        public sbyte stop_mode;
        //  <STOP_TYPE> stop_mode       

        public DrlStopRequest()
        {
            this.stop_mode = 0;
        }

        public DrlStopRequest(sbyte stop_mode)
        {
            this.stop_mode = stop_mode;
        }

        public static DrlStopRequest Deserialize(MessageDeserializer deserializer) => new DrlStopRequest(deserializer);

        private DrlStopRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.stop_mode);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.stop_mode);
        }

        public override string ToString()
        {
            return "DrlStopRequest: " +
            "\nstop_mode: " + stop_mode.ToString();
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
