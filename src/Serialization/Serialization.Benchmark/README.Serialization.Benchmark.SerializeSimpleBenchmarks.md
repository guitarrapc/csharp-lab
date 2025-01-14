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
| SystemTextJson          | Seria(...)Class [26] | 411.93 ns | 38.025 ns | 2.084 ns | 409.91 ns | 414.07 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 323.22 ns |  8.456 ns | 0.463 ns | 322.70 ns | 323.58 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  88.39 ns | 12.696 ns | 0.696 ns |  87.76 ns |  89.14 ns | 0.0076 |     128 B |
