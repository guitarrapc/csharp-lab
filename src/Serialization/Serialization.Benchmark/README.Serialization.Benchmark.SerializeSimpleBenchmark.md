```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 433.8 ns | 27.03 ns | 1.48 ns | 432.3 ns | 435.3 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 338.0 ns | 10.89 ns | 0.60 ns | 337.5 ns | 338.6 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 101.6 ns |  3.50 ns | 0.19 ns | 101.4 ns | 101.7 ns | 0.0014 |     128 B |
