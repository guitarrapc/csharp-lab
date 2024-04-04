```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 634.43 ns | 85.554 ns | 4.689 ns | 631.35 ns | 639.83 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 695.87 ns | 33.291 ns | 1.825 ns | 693.76 ns | 696.94 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.18 ns |  1.951 ns | 0.107 ns |  59.06 ns |  59.26 ns | 0.0014 |     120 B |
