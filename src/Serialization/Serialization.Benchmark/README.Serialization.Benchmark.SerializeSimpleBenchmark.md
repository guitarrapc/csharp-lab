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
| SystemTextJson          | Seria(...)Class [26] | 484.4 ns | 74.01 ns | 4.06 ns | 479.7 ns | 486.9 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 335.5 ns | 18.79 ns | 1.03 ns | 334.6 ns | 336.6 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 101.8 ns |  7.06 ns | 0.39 ns | 101.5 ns | 102.2 ns | 0.0014 |     128 B |
