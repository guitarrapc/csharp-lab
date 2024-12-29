```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 594.97 ns | 39.123 ns | 2.144 ns | 592.88 ns | 597.17 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 643.44 ns | 19.154 ns | 1.050 ns | 642.73 ns | 644.64 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  73.30 ns |  1.548 ns | 0.085 ns |  73.21 ns |  73.36 ns | 0.0014 |     120 B |
