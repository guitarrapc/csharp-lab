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
| SystemTextJson          | Seria(...)Class [26] | 436.6 ns | 14.95 ns | 0.82 ns | 435.9 ns | 437.5 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 333.6 ns |  7.88 ns | 0.43 ns | 333.2 ns | 334.1 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 102.2 ns |  1.47 ns | 0.08 ns | 102.1 ns | 102.2 ns | 0.0014 |     128 B |
