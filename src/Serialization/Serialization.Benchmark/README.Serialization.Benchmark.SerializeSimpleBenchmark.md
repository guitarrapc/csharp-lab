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
| SystemTextJson          | Seria(...)Class [26] | 436.2 ns | 19.78 ns | 1.08 ns | 435.5 ns | 437.4 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 330.4 ns | 15.60 ns | 0.85 ns | 329.7 ns | 331.4 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 105.1 ns | 12.89 ns | 0.71 ns | 104.3 ns | 105.7 ns | 0.0014 |     128 B |
