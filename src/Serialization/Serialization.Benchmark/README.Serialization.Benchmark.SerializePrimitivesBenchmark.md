```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,012.12 ns | 37.959 ns | 2.081 ns | 1,010.30 ns | 1,014.39 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   910.71 ns |  3.321 ns | 0.182 ns |   910.53 ns |   910.90 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.94 ns |  2.665 ns | 0.146 ns |    94.78 ns |    95.05 ns | 0.0014 |     120 B |
