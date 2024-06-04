```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 442.2 ns | 97.22 ns | 5.33 ns | 438.6 ns | 448.3 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 335.9 ns | 29.54 ns | 1.62 ns | 334.1 ns | 337.3 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 101.0 ns |  6.92 ns | 0.38 ns | 100.6 ns | 101.3 ns | 0.0014 |     128 B |
