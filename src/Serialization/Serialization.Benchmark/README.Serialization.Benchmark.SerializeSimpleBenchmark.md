```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error   | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|--------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 396.2 ns | 8.35 ns | 0.46 ns | 395.7 ns | 396.5 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 319.0 ns | 4.05 ns | 0.22 ns | 318.7 ns | 319.2 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 101.3 ns | 2.93 ns | 0.16 ns | 101.2 ns | 101.5 ns | 0.0014 |     128 B |
