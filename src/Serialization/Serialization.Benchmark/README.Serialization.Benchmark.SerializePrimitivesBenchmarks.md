```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,000.60 ns | 19.741 ns | 1.082 ns | 999.62 ns | 1,001.76 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   919.20 ns |  7.409 ns | 0.406 ns | 918.74 ns |   919.46 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.86 ns |  3.068 ns | 0.168 ns |  94.75 ns |    95.06 ns | 0.0014 |     120 B |
