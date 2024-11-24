```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 431.6 ns | 32.85 ns | 1.80 ns | 430.1 ns | 433.6 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 347.4 ns | 25.78 ns | 1.41 ns | 346.5 ns | 349.1 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 103.3 ns |  3.66 ns | 0.20 ns | 103.2 ns | 103.6 ns | 0.0014 |     128 B |
