//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class SetStiffnessxRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/SetStiffnessx";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  set_stiffnessx  
        // ____________________________________________________________________________________________
        public double[] stx;
        //  default[500, 500, 500, 100, 100, 100], Three translational stiffnesses + Three rotational stiffnesses
        public sbyte @ref;
        //  the preset reference coordinate system.
        public double time;
        //  Stiffness varying time(0 ~ 1.0) [sec], Linear transition during the specified time   

        public SetStiffnessxRequest()
        {
            this.stx = new double[6];
            this.@ref = 0;
            this.time = 0.0;
        }

        public SetStiffnessxRequest(double[] stx, sbyte @ref, double time)
        {
            this.stx = stx;
            this.@ref = @ref;
            this.time = time;
        }

        public static SetStiffnessxRequest Deserialize(MessageDeserializer deserializer) => new SetStiffnessxRequest(deserializer);

        private SetStiffnessxRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.stx, sizeof(double), 6);
            deserializer.Read(out this.@ref);
            deserializer.Read(out this.time);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.stx);
            serializer.Write(this.@ref);
            serializer.Write(this.time);
        }

        public override string ToString()
        {
            return "SetStiffnessxRequest: " +
            "\nstx: " + System.String.Join(", ", stx.ToList()) +
            "\n@ref: " + @ref.ToString() +
            "\ntime: " + time.ToString();
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