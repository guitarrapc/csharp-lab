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
| SystemTextJson          | Seria(...)Class [26] | 439.4 ns | 63.58 ns | 3.49 ns | 436.8 ns | 443.4 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 360.4 ns | 55.90 ns | 3.06 ns | 356.9 ns | 362.6 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 103.7 ns |  4.14 ns | 0.23 ns | 103.5 ns | 104.0 ns | 0.0014 |     128 B |
