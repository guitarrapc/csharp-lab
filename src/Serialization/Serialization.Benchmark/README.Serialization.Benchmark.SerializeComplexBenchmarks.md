```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 631.30 ns | 216.36 ns | 11.859 ns | 617.64 ns | 638.99 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 707.76 ns | 188.42 ns | 10.328 ns | 697.34 ns | 717.99 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.65 ns |  45.61 ns |  2.500 ns |  55.77 ns |  60.11 ns | 0.0014 |     120 B |
