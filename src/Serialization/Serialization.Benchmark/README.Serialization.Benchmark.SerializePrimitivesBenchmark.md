```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,015.67 ns | 12.300 ns | 0.674 ns | 1,015.19 ns | 1,016.44 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   931.92 ns | 27.865 ns | 1.527 ns |   930.16 ns |   932.96 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.16 ns |  1.467 ns | 0.080 ns |    92.08 ns |    92.24 ns | 0.0014 |     120 B |
