```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 428.62 ns |  0.817 ns | 0.045 ns | 428.58 ns | 428.67 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 325.18 ns | 25.033 ns | 1.372 ns | 323.91 ns | 326.64 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  94.20 ns | 11.391 ns | 0.624 ns |  93.67 ns |  94.89 ns | 0.0076 |     128 B |
