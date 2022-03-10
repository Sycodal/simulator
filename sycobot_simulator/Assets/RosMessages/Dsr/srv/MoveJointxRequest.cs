//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class MoveJointxRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/MoveJointx";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  move_jointx  
        // ____________________________________________________________________________________________
        public double[] pos;
        //  target  
        public double vel;
        //  set velocity: [deg/sec]
        public double acc;
        //  set acceleration: [deg/sec2] 
        public double time;
        // = 0.0      # Time [sec] 
        public double radius;
        // =0.0     # Radius under blending mode [mm]   
        public sbyte @ref;
        //  DR_BASE(0), DR_TOOL(1), DR_WORLD(2)
        //  <DR_WORLD is only available in M2.40 or later> 
        public sbyte mode;
        // = 0        # MOVE_MODE_ABSOLUTE=0, MOVE_MODE_RELATIVE=1 
        public sbyte blendType;
        // = 0   # BLENDING_SPEED_TYPE_DUPLICATE=0, BLENDING_SPEED_TYPE_OVERRIDE=1
        public sbyte sol;
        //  SolutionSpace : 0~7
        public sbyte syncType;
        // =0     # SYNC = 0, ASYNC = 1

        public MoveJointxRequest()
        {
            this.pos = new double[6];
            this.vel = 0.0;
            this.acc = 0.0;
            this.time = 0.0;
            this.radius = 0.0;
            this.@ref = 0;
            this.mode = 0;
            this.blendType = 0;
            this.sol = 0;
            this.syncType = 0;
        }

        public MoveJointxRequest(double[] pos, double vel, double acc, double time, double radius, sbyte @ref, sbyte mode, sbyte blendType, sbyte sol, sbyte syncType)
        {
            this.pos = pos;
            this.vel = vel;
            this.acc = acc;
            this.time = time;
            this.radius = radius;
            this.@ref = @ref;
            this.mode = mode;
            this.blendType = blendType;
            this.sol = sol;
            this.syncType = syncType;
        }

        public static MoveJointxRequest Deserialize(MessageDeserializer deserializer) => new MoveJointxRequest(deserializer);

        private MoveJointxRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.pos, sizeof(double), 6);
            deserializer.Read(out this.vel);
            deserializer.Read(out this.acc);
            deserializer.Read(out this.time);
            deserializer.Read(out this.radius);
            deserializer.Read(out this.@ref);
            deserializer.Read(out this.mode);
            deserializer.Read(out this.blendType);
            deserializer.Read(out this.sol);
            deserializer.Read(out this.syncType);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.pos);
            serializer.Write(this.vel);
            serializer.Write(this.acc);
            serializer.Write(this.time);
            serializer.Write(this.radius);
            serializer.Write(this.@ref);
            serializer.Write(this.mode);
            serializer.Write(this.blendType);
            serializer.Write(this.sol);
            serializer.Write(this.syncType);
        }

        public override string ToString()
        {
            return "MoveJointxRequest: " +
            "\npos: " + System.String.Join(", ", pos.ToList()) +
            "\nvel: " + vel.ToString() +
            "\nacc: " + acc.ToString() +
            "\ntime: " + time.ToString() +
            "\nradius: " + radius.ToString() +
            "\n@ref: " + @ref.ToString() +
            "\nmode: " + mode.ToString() +
            "\nblendType: " + blendType.ToString() +
            "\nsol: " + sol.ToString() +
            "\nsyncType: " + syncType.ToString();
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
