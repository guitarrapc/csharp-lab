```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 402.2 ns |  75.75 ns | 4.15 ns | 398.8 ns | 406.9 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 353.3 ns | 105.42 ns | 5.78 ns | 348.0 ns | 359.5 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 103.5 ns |   8.88 ns | 0.49 ns | 103.1 ns | 104.1 ns | 0.0014 |     128 B |
