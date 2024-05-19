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
| SystemTextJson          | Seria(...)Class [26] | 451.1 ns | 36.78 ns | 2.02 ns | 449.7 ns | 453.4 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 345.4 ns | 22.84 ns | 1.25 ns | 343.9 ns | 346.3 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 103.3 ns |  1.22 ns | 0.07 ns | 103.3 ns | 103.4 ns | 0.0014 |     128 B |
