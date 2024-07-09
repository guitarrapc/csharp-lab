```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean       | Error    | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------------ |--------------------- |-----------:|---------:|--------:|-----------:|-----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,004.0 ns | 45.59 ns | 2.50 ns | 1,002.4 ns | 1,006.9 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   901.9 ns | 15.99 ns | 0.88 ns |   901.3 ns |   902.9 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |   106.5 ns |  1.05 ns | 0.06 ns |   106.4 ns |   106.5 ns | 0.0014 |     120 B |
