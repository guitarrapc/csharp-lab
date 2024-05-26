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
| SystemTextJson          | Seria(...)Class [26] | 435.1 ns | 25.59 ns | 1.40 ns | 433.8 ns | 436.6 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 331.3 ns | 15.24 ns | 0.84 ns | 330.3 ns | 332.0 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 103.0 ns |  3.60 ns | 0.20 ns | 102.8 ns | 103.2 ns | 0.0014 |     128 B |
