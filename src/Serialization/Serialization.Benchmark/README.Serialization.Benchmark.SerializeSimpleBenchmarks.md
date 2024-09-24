```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 489.4 ns | 22.76 ns | 1.25 ns | 488.5 ns | 490.8 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 356.9 ns | 38.56 ns | 2.11 ns | 355.3 ns | 359.3 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 103.2 ns |  1.90 ns | 0.10 ns | 103.1 ns | 103.3 ns | 0.0014 |     128 B |
