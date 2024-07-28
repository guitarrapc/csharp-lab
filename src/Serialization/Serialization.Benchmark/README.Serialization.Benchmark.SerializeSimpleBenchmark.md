```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 505.7 ns | 276.53 ns | 15.16 ns | 496.5 ns | 523.2 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 401.0 ns |  30.71 ns |  1.68 ns | 399.2 ns | 402.6 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 116.2 ns |   1.33 ns |  0.07 ns | 116.1 ns | 116.3 ns | 0.0014 |     128 B |
