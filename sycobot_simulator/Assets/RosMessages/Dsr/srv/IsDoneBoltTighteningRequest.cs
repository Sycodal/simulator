//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class IsDoneBoltTighteningRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/IsDoneBoltTightening";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  is_done_bolt_tightening  
        // ____________________________________________________________________________________________
        public double m;
        //  Target torque  
        public double timeout;
        //  Monitoring duration [sec]  
        public sbyte axis;
        //  DR_AXIS_X(0), DR_AXIS_Y(1), DR_AXIS_Z(2) 

        public IsDoneBoltTighteningRequest()
        {
            this.m = 0.0;
            this.timeout = 0.0;
            this.axis = 0;
        }

        public IsDoneBoltTighteningRequest(double m, double timeout, sbyte axis)
        {
            this.m = m;
            this.timeout = timeout;
            this.axis = axis;
        }

        public static IsDoneBoltTighteningRequest Deserialize(MessageDeserializer deserializer) => new IsDoneBoltTighteningRequest(deserializer);

        private IsDoneBoltTighteningRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.m);
            deserializer.Read(out this.timeout);
            deserializer.Read(out this.axis);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.m);
            serializer.Write(this.timeout);
            serializer.Write(this.axis);
        }

        public override string ToString()
        {
            return "IsDoneBoltTighteningRequest: " +
            "\nm: " + m.ToString() +
            "\ntimeout: " + timeout.ToString() +
            "\naxis: " + axis.ToString();
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
