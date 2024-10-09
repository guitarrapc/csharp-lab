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
| SystemTextJson          | Seria(...)tives [29] | 1,015.16 ns | 83.778 ns | 4.592 ns | 1,012.12 ns | 1,020.45 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   921.71 ns | 48.919 ns | 2.681 ns |   918.71 ns |   923.88 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.23 ns |  4.117 ns | 0.226 ns |    95.07 ns |    95.48 ns | 0.0014 |     120 B |
