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
| SystemTextJson          | Seria(...)tives [29] | 1,006.43 ns | 20.840 ns | 1.142 ns | 1,005.28 ns | 1,007.56 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   904.25 ns | 14.010 ns | 0.768 ns |   903.39 ns |   904.87 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.61 ns |  0.639 ns | 0.035 ns |    92.58 ns |    92.65 ns | 0.0014 |     120 B |
