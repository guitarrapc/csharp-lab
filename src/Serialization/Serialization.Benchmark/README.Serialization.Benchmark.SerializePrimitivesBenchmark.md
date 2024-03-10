```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev    | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|----------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,000.31 ns |  36.986 ns |  2.027 ns | 998.98 ns | 1,002.64 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   963.14 ns | 324.011 ns | 17.760 ns | 952.89 ns |   983.65 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    93.18 ns |   7.564 ns |  0.415 ns |  92.84 ns |    93.64 ns | 0.0014 |     120 B |
