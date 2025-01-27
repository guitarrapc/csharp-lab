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
| SystemTextJson          | Seria(...)tives [29] | 956.27 ns | 97.00 ns | 5.317 ns | 953.11 ns | 962.41 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 867.72 ns | 84.67 ns | 4.641 ns | 864.48 ns | 873.04 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  77.72 ns | 14.67 ns | 0.804 ns |  76.93 ns |  78.54 ns | 0.0072 |     120 B |
