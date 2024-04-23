```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 434.2 ns | 20.76 ns | 1.14 ns | 433.3 ns | 435.5 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 332.6 ns |  7.51 ns | 0.41 ns | 332.3 ns | 333.0 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 107.8 ns |  1.42 ns | 0.08 ns | 107.7 ns | 107.9 ns | 0.0014 |     128 B |
