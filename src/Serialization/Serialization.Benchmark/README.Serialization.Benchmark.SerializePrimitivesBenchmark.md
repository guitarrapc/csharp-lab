```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,017.27 ns | 513.524 ns | 28.148 ns | 1,000.52 ns | 1,049.77 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   909.77 ns |  15.444 ns |  0.847 ns |   908.82 ns |   910.43 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.73 ns |   2.308 ns |  0.127 ns |    92.63 ns |    92.87 ns | 0.0014 |     120 B |
