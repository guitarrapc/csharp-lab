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
| SystemTextJson          | Seria(...)Class [26] | 420.5 ns | 20.27 ns | 1.11 ns | 419.3 ns | 421.5 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 345.1 ns | 16.58 ns | 0.91 ns | 344.3 ns | 346.1 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 103.5 ns |  5.48 ns | 0.30 ns | 103.3 ns | 103.9 ns | 0.0014 |     128 B |
