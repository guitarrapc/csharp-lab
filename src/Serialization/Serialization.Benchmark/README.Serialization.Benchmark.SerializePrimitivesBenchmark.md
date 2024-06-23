```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,008.78 ns | 48.207 ns | 2.642 ns | 1,006.10 ns | 1,011.38 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   902.89 ns | 48.229 ns | 2.644 ns |   901.10 ns |   905.93 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.59 ns |  3.122 ns | 0.171 ns |    92.47 ns |    92.78 ns | 0.0014 |     120 B |
