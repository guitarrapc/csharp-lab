```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 417.13 ns | 44.07 ns | 2.416 ns | 414.82 ns | 419.64 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 336.62 ns | 44.38 ns | 2.433 ns | 334.21 ns | 339.08 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  87.98 ns | 19.92 ns | 1.092 ns |  87.15 ns |  89.21 ns | 0.0076 |     128 B |
