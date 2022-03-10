//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetSingularityHandlingRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetSingularityHandling";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  set_singularity_handling
        //  
        // ____________________________________________________________________________________________
        public sbyte mode;
        //  DR_AVOID(0)     : Automatic avoidance mode
        //  DR_TASK_STOP(1) : Deceleration/ Warning/ Task termination
        //  DR_VAR_VEL(2)   : Variable velocity mode

        public SetSingularityHandlingRequest()
        {
            this.mode = 0;
        }

        public SetSingularityHandlingRequest(sbyte mode)
        {
            this.mode = mode;
        }

        public static SetSingularityHandlingRequest Deserialize(MessageDeserializer deserializer) => new SetSingularityHandlingRequest(deserializer);

        private SetSingularityHandlingRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.mode);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.mode);
        }

        public override string ToString()
        {
            return "SetSingularityHandlingRequest: " +
            "\nmode: " + mode.ToString();
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
