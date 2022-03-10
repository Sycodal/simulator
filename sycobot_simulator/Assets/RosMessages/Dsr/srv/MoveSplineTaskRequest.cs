//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class MoveSplineTaskRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/MoveSplineTask";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  move_spline_task  
        // ##float64[100][6] pos            # target
        // ____________________________________________________________________________________________
        public Std.Float64MultiArrayMsg[] pos;
        //  target 
        public sbyte posCnt;
        //  target cnt 
        public double[] vel;
        //  set velocity: [mm/sec], [deg/sec]
        public double[] acc;
        //  set acceleration: [mm/sec2], [deg/sec2]
        public double time;
        // = 0.0       # Time [sec] 
        public sbyte @ref;
        //  DR_BASE(0), DR_TOOL(1), DR_WORLD(2)
        //  <DR_WORLD is only available in M2.40 or later 
        public sbyte mode;
        // = 0         # MOVE_MODE_ABSOLUTE=0, MOVE_MODE_RELATIVE=1 
        public sbyte opt;
        // = 0         # SPLINE_VELOCITY_OPTION_DEFAULT=0, SPLINE_VELOCITY_OPTION_CONST=1 
        public sbyte syncType;
        // =0      # SYNC = 0, ASYNC = 1

        public MoveSplineTaskRequest()
        {
            this.pos = new Std.Float64MultiArrayMsg[0];
            this.posCnt = 0;
            this.vel = new double[2];
            this.acc = new double[2];
            this.time = 0.0;
            this.@ref = 0;
            this.mode = 0;
            this.opt = 0;
            this.syncType = 0;
        }

        public MoveSplineTaskRequest(Std.Float64MultiArrayMsg[] pos, sbyte posCnt, double[] vel, double[] acc, double time, sbyte @ref, sbyte mode, sbyte opt, sbyte syncType)
        {
            this.pos = pos;
            this.posCnt = posCnt;
            this.vel = vel;
            this.acc = acc;
            this.time = time;
            this.@ref = @ref;
            this.mode = mode;
            this.opt = opt;
            this.syncType = syncType;
        }

        public static MoveSplineTaskRequest Deserialize(MessageDeserializer deserializer) => new MoveSplineTaskRequest(deserializer);

        private MoveSplineTaskRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.pos, Std.Float64MultiArrayMsg.Deserialize, deserializer.ReadLength());
            deserializer.Read(out this.posCnt);
            deserializer.Read(out this.vel, sizeof(double), 2);
            deserializer.Read(out this.acc, sizeof(double), 2);
            deserializer.Read(out this.time);
            deserializer.Read(out this.@ref);
            deserializer.Read(out this.mode);
            deserializer.Read(out this.opt);
            deserializer.Read(out this.syncType);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.pos);
            serializer.Write(this.pos);
            serializer.Write(this.posCnt);
            serializer.Write(this.vel);
            serializer.Write(this.acc);
            serializer.Write(this.time);
            serializer.Write(this.@ref);
            serializer.Write(this.mode);
            serializer.Write(this.opt);
            serializer.Write(this.syncType);
        }

        public override string ToString()
        {
            return "MoveSplineTaskRequest: " +
            "\npos: " + System.String.Join(", ", pos.ToList()) +
            "\nposCnt: " + posCnt.ToString() +
            "\nvel: " + System.String.Join(", ", vel.ToList()) +
            "\nacc: " + System.String.Join(", ", acc.ToList()) +
            "\ntime: " + time.ToString() +
            "\n@ref: " + @ref.ToString() +
            "\nmode: " + mode.ToString() +
            "\nopt: " + opt.ToString() +
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
