```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 995.3 ns | 58.17 ns | 3.19 ns | 991.6 ns | 997.3 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 920.4 ns | 10.58 ns | 0.58 ns | 919.8 ns | 920.9 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] | 102.4 ns |  1.69 ns | 0.09 ns | 102.4 ns | 102.5 ns | 0.0014 |     120 B |
