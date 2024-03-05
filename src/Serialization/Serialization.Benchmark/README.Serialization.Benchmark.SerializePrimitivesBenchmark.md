```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev  | Min      | Max        | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|--------:|---------:|-----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 995.0 ns | 138.14 ns | 7.57 ns | 987.4 ns | 1,002.5 ns | 0.0038 |     432 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 926.5 ns |  74.58 ns | 4.09 ns | 922.7 ns |   930.8 ns | 0.0057 |     544 B |
