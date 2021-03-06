//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetSafeStopResetTypeRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetSafeStopResetType";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  set_safe_stop_reset_type
        // ____________________________________________________________________________________________
        public sbyte reset_type;
        //  0=SAFE_STOP_RESET_TYPE_DEFAULT = SAFE_STOP_RESET_TYPE_PROGRAM_STOP , 1= SAFE_STOP_RESET_TYPE_PROGRAM_RESUME 

        public SetSafeStopResetTypeRequest()
        {
            this.reset_type = 0;
        }

        public SetSafeStopResetTypeRequest(sbyte reset_type)
        {
            this.reset_type = reset_type;
        }

        public static SetSafeStopResetTypeRequest Deserialize(MessageDeserializer deserializer) => new SetSafeStopResetTypeRequest(deserializer);

        private SetSafeStopResetTypeRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.reset_type);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.reset_type);
        }

        public override string ToString()
        {
            return "SetSafeStopResetTypeRequest: " +
            "\nreset_type: " + reset_type.ToString();
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
