```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 990.5 ns | 50.06 ns | 2.74 ns | 987.5 ns | 992.8 ns | 0.0038 |     432 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 926.6 ns | 12.47 ns | 0.68 ns | 925.8 ns | 927.1 ns | 0.0057 |     544 B |
