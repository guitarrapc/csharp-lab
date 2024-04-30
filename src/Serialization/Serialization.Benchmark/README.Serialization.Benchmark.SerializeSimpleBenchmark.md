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
| SystemTextJson          | Seria(...)Class [26] | 462.4 ns | 17.33 ns | 0.95 ns | 461.4 ns | 463.2 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 340.2 ns | 14.19 ns | 0.78 ns | 339.3 ns | 340.7 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 101.3 ns |  4.12 ns | 0.23 ns | 101.0 ns | 101.5 ns | 0.0014 |     128 B |
