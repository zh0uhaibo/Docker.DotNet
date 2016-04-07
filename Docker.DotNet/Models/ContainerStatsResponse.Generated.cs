using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [DataContract]
    public class ContainerStatsResponse // (types.StatsJSON)
    {
        public ContainerStatsResponse()
        {
        }

        public ContainerStatsResponse(Stats Stats)
        {
            if (Stats != null)            {
                this.Read = Stats.Read;
                this.PreCPUStats = Stats.PreCPUStats;
                this.CPUStats = Stats.CPUStats;
                this.MemoryStats = Stats.MemoryStats;
                this.BlkioStats = Stats.BlkioStats;
                this.PidsStats = Stats.PidsStats;
            }
        }

        [DataMember(Name = "read")]
        public DateTime Read { get; set; }

        [DataMember(Name = "precpu_stats")]
        public CPUStats PreCPUStats { get; set; }

        [DataMember(Name = "cpu_stats")]
        public CPUStats CPUStats { get; set; }

        [DataMember(Name = "memory_stats")]
        public MemoryStats MemoryStats { get; set; }

        [DataMember(Name = "blkio_stats")]
        public BlkioStats BlkioStats { get; set; }

        [DataMember(Name = "pids_stats")]
        public PidsStats PidsStats { get; set; }

        [DataMember(Name = "networks")]
        public IDictionary<string, NetworkStats> Networks { get; set; }
    }
}
