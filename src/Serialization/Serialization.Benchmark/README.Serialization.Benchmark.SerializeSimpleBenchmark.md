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
| SystemTextJson          | Seria(...)Class [26] | 379.2 ns | 80.76 ns | 4.43 ns | 376.7 ns | 384.4 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 327.1 ns |  9.30 ns | 0.51 ns | 326.5 ns | 327.6 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 102.0 ns | 25.67 ns | 1.41 ns | 101.2 ns | 103.7 ns | 0.0014 |     128 B |
