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
| SystemTextJson          | Seria(...)Class [26] | 393.84 ns | 14.25 ns | 0.781 ns | 393.10 ns | 394.66 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 342.68 ns | 14.63 ns | 0.802 ns | 341.97 ns | 343.55 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  91.93 ns | 30.00 ns | 1.645 ns |  90.80 ns |  93.81 ns | 0.0076 |     128 B |
