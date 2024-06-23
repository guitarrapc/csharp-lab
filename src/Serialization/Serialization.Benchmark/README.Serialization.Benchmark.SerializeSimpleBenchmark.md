```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min       | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|----------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 422.7 ns | 12.77 ns | 0.70 ns | 422.28 ns | 423.5 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 332.0 ns |  7.48 ns | 0.41 ns | 331.57 ns | 332.4 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 100.2 ns |  6.73 ns | 0.37 ns |  99.94 ns | 100.6 ns | 0.0014 |     128 B |
