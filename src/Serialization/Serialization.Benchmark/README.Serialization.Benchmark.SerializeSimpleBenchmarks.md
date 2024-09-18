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
| SystemTextJson          | Seria(...)Class [26] | 475.9 ns | 12.56 ns | 0.69 ns | 475.3 ns | 476.6 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 346.0 ns | 19.55 ns | 1.07 ns | 345.0 ns | 347.1 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 102.6 ns |  3.52 ns | 0.19 ns | 102.4 ns | 102.8 ns | 0.0014 |     128 B |
