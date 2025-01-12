```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 397.71 ns |  9.286 ns | 0.509 ns | 397.30 ns | 398.28 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 327.10 ns | 95.432 ns | 5.231 ns | 324.05 ns | 333.14 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  84.47 ns | 10.711 ns | 0.587 ns |  83.80 ns |  84.90 ns | 0.0076 |     128 B |
