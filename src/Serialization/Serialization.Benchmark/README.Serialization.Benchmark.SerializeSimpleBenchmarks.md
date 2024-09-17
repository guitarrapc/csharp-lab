```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 434.8 ns | 24.46 ns | 1.34 ns | 433.6 ns | 436.2 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 351.8 ns | 49.05 ns | 2.69 ns | 350.0 ns | 354.9 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 104.0 ns |  4.76 ns | 0.26 ns | 103.8 ns | 104.3 ns | 0.0014 |     128 B |
