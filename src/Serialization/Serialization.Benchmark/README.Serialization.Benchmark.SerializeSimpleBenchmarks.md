```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 372.3 ns | 38.13 ns | 2.09 ns | 370.7 ns | 374.7 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 333.1 ns |  4.56 ns | 0.25 ns | 332.9 ns | 333.4 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 106.0 ns |  1.11 ns | 0.06 ns | 106.0 ns | 106.1 ns | 0.0014 |     128 B |
