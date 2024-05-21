```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 432.4 ns | 42.28 ns | 2.32 ns | 431.0 ns | 435.1 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 345.8 ns | 21.30 ns | 1.17 ns | 344.4 ns | 346.5 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 105.6 ns |  0.60 ns | 0.03 ns | 105.5 ns | 105.6 ns | 0.0014 |     128 B |
