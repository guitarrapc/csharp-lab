```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,001.06 ns | 56.943 ns | 3.121 ns | 998.89 ns | 1,004.64 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   896.84 ns | 54.083 ns | 2.964 ns | 894.04 ns |   899.94 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.70 ns |  1.642 ns | 0.090 ns |  94.60 ns |    94.78 ns | 0.0014 |     120 B |
