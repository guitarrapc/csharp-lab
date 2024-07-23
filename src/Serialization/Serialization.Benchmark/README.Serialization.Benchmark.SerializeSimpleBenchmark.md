```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error   | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|--------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 420.6 ns | 9.28 ns | 0.51 ns | 420.0 ns | 421.0 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 328.5 ns | 6.84 ns | 0.38 ns | 328.1 ns | 328.9 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 104.3 ns | 0.90 ns | 0.05 ns | 104.2 ns | 104.3 ns | 0.0014 |     128 B |
