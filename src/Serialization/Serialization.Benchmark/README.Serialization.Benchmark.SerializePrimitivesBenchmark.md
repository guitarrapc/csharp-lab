```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean       | Error    | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------------ |--------------------- |-----------:|---------:|--------:|-----------:|-----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,047.9 ns | 63.66 ns | 3.49 ns | 1,044.1 ns | 1,051.0 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   950.1 ns | 97.29 ns | 5.33 ns |   945.9 ns |   956.1 ns | 0.0057 |     568 B |
| MemoryPack              | Seria(...)tives [29] |   111.0 ns |  1.50 ns | 0.08 ns |   110.9 ns |   111.0 ns | 0.0014 |     120 B |
