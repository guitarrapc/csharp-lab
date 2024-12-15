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
| SystemTextJson          | Seria(...)Class [26] | 431.0 ns | 15.76 ns | 0.86 ns | 430.4 ns | 432.0 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 328.3 ns | 23.15 ns | 1.27 ns | 327.4 ns | 329.7 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 103.4 ns |  1.62 ns | 0.09 ns | 103.3 ns | 103.5 ns | 0.0014 |     128 B |
