```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 439.6 ns | 24.04 ns | 1.32 ns | 438.1 ns | 440.5 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 345.5 ns | 10.06 ns | 0.55 ns | 344.8 ns | 345.9 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 105.9 ns |  3.49 ns | 0.19 ns | 105.7 ns | 106.0 ns | 0.0014 |     128 B |
