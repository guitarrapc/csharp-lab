```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 994.6 ns | 73.29 ns | 4.02 ns | 991.9 ns | 999.2 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 910.6 ns | 18.43 ns | 1.01 ns | 909.5 ns | 911.6 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] | 102.8 ns |  3.11 ns | 0.17 ns | 102.7 ns | 103.0 ns | 0.0014 |     120 B |
