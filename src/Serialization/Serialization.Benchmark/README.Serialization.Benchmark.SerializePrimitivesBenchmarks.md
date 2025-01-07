```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 980.62 ns |  80.110 ns |  4.391 ns | 975.66 ns | 984.01 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 905.39 ns | 261.553 ns | 14.337 ns | 896.07 ns | 921.90 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  84.72 ns |   1.164 ns |  0.064 ns |  84.67 ns |  84.80 ns | 0.0072 |     120 B |
