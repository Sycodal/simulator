//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class CheckOrientationCondition2Request : Message
    {
        public const string k_RosMessageName = "dsr_msgs/CheckOrientationCondition2";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  check_orientation_condition(axis, min, max, ref, mod, pos)  
        // ____________________________________________________________________________________________
        public sbyte axis;
        //  DR_AXIS_A(10), DR_AXIS_B(11), DR_AXIS_C(12) 
        public double min;
        //  minimum value  
        public double max;
        //  maximum value  
        public sbyte @ref;
        // = 0         # DR_BASE(0), DR_TOOL(1), DR_WORLD(2), user_coordinate(101~200)
        //  <DR_WORLD is only available in M2.40 or later> 
        public sbyte mode;
        // = 1         # DR_MV_MOD_REL(1)
        public double[] pos;
        //  task pos(pos)  

        public CheckOrientationCondition2Request()
        {
            this.axis = 0;
            this.min = 0.0;
            this.max = 0.0;
            this.@ref = 0;
            this.mode = 0;
            this.pos = new double[6];
        }

        public CheckOrientationCondition2Request(sbyte axis, double min, double max, sbyte @ref, sbyte mode, double[] pos)
        {
            this.axis = axis;
            this.min = min;
            this.max = max;
            this.@ref = @ref;
            this.mode = mode;
            this.pos = pos;
        }

        public static CheckOrientationCondition2Request Deserialize(MessageDeserializer deserializer) => new CheckOrientationCondition2Request(deserializer);

        private CheckOrientationCondition2Request(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.axis);
            deserializer.Read(out this.min);
            deserializer.Read(out this.max);
            deserializer.Read(out this.@ref);
            deserializer.Read(out this.mode);
            deserializer.Read(out this.pos, sizeof(double), 6);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.axis);
            serializer.Write(this.min);
            serializer.Write(this.max);
            serializer.Write(this.@ref);
            serializer.Write(this.mode);
            serializer.Write(this.pos);
        }

        public override string ToString()
        {
            return "CheckOrientationCondition2Request: " +
            "\naxis: " + axis.ToString() +
            "\nmin: " + min.ToString() +
            "\nmax: " + max.ToString() +
            "\n@ref: " + @ref.ToString() +
            "\nmode: " + mode.ToString() +
            "\npos: " + System.String.Join(", ", pos.ToList());
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