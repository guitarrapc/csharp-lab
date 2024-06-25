```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,001.23 ns | 114.418 ns | 6.272 ns | 997.06 ns | 1,008.44 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   925.61 ns |  23.562 ns | 1.292 ns | 924.52 ns |   927.03 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.23 ns |   3.328 ns | 0.182 ns |  92.02 ns |    92.35 ns | 0.0014 |     120 B |
