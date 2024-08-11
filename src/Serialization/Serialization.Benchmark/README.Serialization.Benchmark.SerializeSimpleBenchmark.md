```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 359.6 ns | 18.75 ns | 1.03 ns | 358.5 ns | 360.6 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 341.4 ns | 26.33 ns | 1.44 ns | 340.3 ns | 343.0 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 100.6 ns |  0.91 ns | 0.05 ns | 100.5 ns | 100.6 ns | 0.0014 |     128 B |
