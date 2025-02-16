```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   845.6 ns |  52.14 ns |  2.86 ns |   842.5 ns |   848.1 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,451.2 ns | 184.38 ns | 10.11 ns | 1,440.8 ns | 1,460.9 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   897.1 ns |  15.36 ns |  0.84 ns |   896.2 ns |   897.8 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,314.3 ns |  44.46 ns |  2.44 ns | 1,311.6 ns | 1,316.3 ns | 0.1907 | 0.0019 |    3208 B |
