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
| SystemTextJson          | Seria(...)Class [26] | 414.42 ns | 81.51 ns | 4.468 ns | 411.64 ns | 419.57 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 319.39 ns | 40.18 ns | 2.202 ns | 316.99 ns | 321.32 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  88.66 ns | 11.03 ns | 0.604 ns |  87.99 ns |  89.16 ns | 0.0076 |     128 B |
