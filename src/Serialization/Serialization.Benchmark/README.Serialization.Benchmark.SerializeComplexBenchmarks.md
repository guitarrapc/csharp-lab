```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 649.63 ns |  6.080 ns | 0.333 ns | 649.30 ns | 649.97 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 682.03 ns | 11.170 ns | 0.612 ns | 681.52 ns | 682.71 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.39 ns |  1.648 ns | 0.090 ns |  58.29 ns |  58.45 ns | 0.0014 |     120 B |
