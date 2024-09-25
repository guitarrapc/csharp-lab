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
| SystemTextJson          | Seria(...)Class [26] | 435.9 ns | 23.27 ns | 1.28 ns | 435.1 ns | 437.4 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 341.6 ns | 36.98 ns | 2.03 ns | 340.2 ns | 343.9 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 104.5 ns |  2.94 ns | 0.16 ns | 104.4 ns | 104.7 ns | 0.0014 |     128 B |
