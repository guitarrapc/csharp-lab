```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 375.4 ns | 24.77 ns | 1.36 ns | 374.0 ns | 376.7 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 347.6 ns | 39.49 ns | 2.16 ns | 345.3 ns | 349.7 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 106.8 ns |  2.36 ns | 0.13 ns | 106.7 ns | 106.9 ns | 0.0014 |     128 B |
