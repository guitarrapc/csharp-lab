```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,032.39 ns | 14.770 ns | 0.810 ns | 1,031.51 ns | 1,033.09 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   903.51 ns | 68.326 ns | 3.745 ns |   899.62 ns |   907.09 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    97.51 ns |  2.614 ns | 0.143 ns |    97.38 ns |    97.67 ns | 0.0014 |     120 B |
