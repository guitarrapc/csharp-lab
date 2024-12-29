```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error        | StdDev     | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-------------:|-----------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,096.49 ns | 2,404.395 ns | 131.793 ns | 996.08 ns | 1,245.73 ns |      - |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   861.10 ns |    16.592 ns |   0.909 ns | 860.10 ns |   861.86 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    79.10 ns |     4.635 ns |   0.254 ns |  78.91 ns |    79.39 ns | 0.0014 |     120 B |
