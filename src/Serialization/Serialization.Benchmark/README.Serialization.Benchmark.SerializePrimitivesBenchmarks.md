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
| SystemTextJson          | Seria(...)tives [29] | 987.97 ns | 70.877 ns | 3.885 ns | 984.10 ns | 991.87 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 880.80 ns | 59.681 ns | 3.271 ns | 877.72 ns | 884.24 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  76.01 ns |  2.370 ns | 0.130 ns |  75.90 ns |  76.15 ns | 0.0072 |     120 B |
