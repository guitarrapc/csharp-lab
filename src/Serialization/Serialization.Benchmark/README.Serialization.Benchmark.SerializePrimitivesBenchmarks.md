```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,004.91 ns |  6.377 ns | 0.350 ns | 1,004.69 ns | 1,005.31 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   908.15 ns | 32.849 ns | 1.801 ns |   906.70 ns |   910.17 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.60 ns |  6.544 ns | 0.359 ns |    92.19 ns |    92.82 ns | 0.0014 |     120 B |
