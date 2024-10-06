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
| SystemTextJson          | Seria(...)Class [26] | 438.7 ns | 96.38 ns | 5.28 ns | 432.6 ns | 442.0 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 348.2 ns | 39.35 ns | 2.16 ns | 346.3 ns | 350.5 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 102.7 ns |  8.69 ns | 0.48 ns | 102.4 ns | 103.2 ns | 0.0014 |     128 B |
