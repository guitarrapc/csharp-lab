```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 996.7 ns |  15.07 ns | 0.83 ns | 996.2 ns | 997.7 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 989.4 ns | 155.51 ns | 8.52 ns | 984.0 ns | 999.3 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] | 105.0 ns |   4.64 ns | 0.25 ns | 104.8 ns | 105.2 ns | 0.0014 |     120 B |
