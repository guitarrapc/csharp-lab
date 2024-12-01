```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 480.0 ns | 133.95 ns | 7.34 ns | 471.8 ns | 486.1 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 326.1 ns |  15.85 ns | 0.87 ns | 325.2 ns | 326.9 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 100.9 ns |   2.10 ns | 0.11 ns | 100.8 ns | 101.0 ns | 0.0014 |     128 B |
