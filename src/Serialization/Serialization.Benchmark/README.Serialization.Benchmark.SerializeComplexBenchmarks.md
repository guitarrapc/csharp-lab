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
| SystemTextJson          | Seria(...)Class [29] | 594.49 ns | 18.586 ns | 1.019 ns | 593.44 ns | 595.47 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 660.17 ns | 36.144 ns | 1.981 ns | 658.35 ns | 662.28 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  47.90 ns |  2.986 ns | 0.164 ns |  47.72 ns |  48.04 ns | 0.0072 |     120 B |
