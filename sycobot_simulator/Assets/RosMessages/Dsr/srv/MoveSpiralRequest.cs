//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Dsr
{
    [Serializable]
    public class MoveSpiralRequest : Message
    {
        public const string k_RosMessageName = "dsr_msgs/MoveSpiral";
        public override string RosMessageName => k_RosMessageName;

        // ____________________________________________________________________________________________
        //  move_sprial  
        // ____________________________________________________________________________________________
        public double revolution;
        //  Total number of revolutions 
        public double maxRadius;
        //  Final spiral radius [mm]
        public double maxLength;
        //  Distance moved in the axis direction [mm]
        public double[] vel;
        //  set velocity: [mm/sec], [deg/sec]
        public double[] acc;
        //  set acceleration: [mm/sec2], [deg/sec2]
        public double time;
        // = 0.0      # Total execution time <sec> 
        public sbyte taskAxis;
        //  TASK_AXIS_X = 0, TASK_AXIS_Y = 1, TASK_AXIS_Z = 2   
        public sbyte @ref;
        // = 1        # DR_BASE(0), DR_TOOL(1), DR_WORLD(2)
        //  <DR_WORLD is only available in M2.40 or later 
        public sbyte syncType;
        // =0     # SYNC = 0, ASYNC = 1 

        public MoveSpiralRequest()
        {
            this.revolution = 0.0;
            this.maxRadius = 0.0;
            this.maxLength = 0.0;
            this.vel = new double[2];
            this.acc = new double[2];
            this.time = 0.0;
            this.taskAxis = 0;
            this.@ref = 0;
            this.syncType = 0;
        }

        public MoveSpiralRequest(double revolution, double maxRadius, double maxLength, double[] vel, double[] acc, double time, sbyte taskAxis, sbyte @ref, sbyte syncType)
        {
            this.revolution = revolution;
            this.maxRadius = maxRadius;
            this.maxLength = maxLength;
            this.vel = vel;
            this.acc = acc;
            this.time = time;
            this.taskAxis = taskAxis;
            this.@ref = @ref;
            this.syncType = syncType;
        }

        public static MoveSpiralRequest Deserialize(MessageDeserializer deserializer) => new MoveSpiralRequest(deserializer);

        private MoveSpiralRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.revolution);
            deserializer.Read(out this.maxRadius);
            deserializer.Read(out this.maxLength);
            deserializer.Read(out this.vel, sizeof(double), 2);
            deserializer.Read(out this.acc, sizeof(double), 2);
            deserializer.Read(out this.time);
            deserializer.Read(out this.taskAxis);
            deserializer.Read(out this.@ref);
            deserializer.Read(out this.syncType);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.revolution);
            serializer.Write(this.maxRadius);
            serializer.Write(this.maxLength);
            serializer.Write(this.vel);
            serializer.Write(this.acc);
            serializer.Write(this.time);
            serializer.Write(this.taskAxis);
            serializer.Write(this.@ref);
            serializer.Write(this.syncType);
        }

        public override string ToString()
        {
            return "MoveSpiralRequest: " +
            "\nrevolution: " + revolution.ToString() +
            "\nmaxRadius: " + maxRadius.ToString() +
            "\nmaxLength: " + maxLength.ToString() +
            "\nvel: " + System.String.Join(", ", vel.ToList()) +
            "\nacc: " + System.String.Join(", ", acc.ToList()) +
            "\ntime: " + time.ToString() +
            "\ntaskAxis: " + taskAxis.ToString() +
            "\n@ref: " + @ref.ToString() +
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
