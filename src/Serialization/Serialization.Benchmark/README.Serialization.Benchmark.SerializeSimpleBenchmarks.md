```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 438.7 ns | 57.80 ns | 3.17 ns | 435.1 ns | 441.0 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 411.1 ns | 38.11 ns | 2.09 ns | 408.8 ns | 412.9 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 103.2 ns |  6.42 ns | 0.35 ns | 103.0 ns | 103.6 ns | 0.0014 |     128 B |
