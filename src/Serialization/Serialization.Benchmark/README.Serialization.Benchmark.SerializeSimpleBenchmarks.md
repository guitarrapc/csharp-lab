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
| SystemTextJson          | Seria(...)Class [26] | 397.04 ns | 16.417 ns | 0.900 ns | 396.28 ns | 398.04 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 322.50 ns | 58.774 ns | 3.222 ns | 318.91 ns | 325.15 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  89.31 ns |  6.126 ns | 0.336 ns |  89.07 ns |  89.69 ns | 0.0076 |     128 B |
