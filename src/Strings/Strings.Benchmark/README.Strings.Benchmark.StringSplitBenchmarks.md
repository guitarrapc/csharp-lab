```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   840.9 ns |  17.92 ns |  0.98 ns |   840.1 ns |   842.0 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,972.3 ns | 968.62 ns | 53.09 ns | 1,917.5 ns | 2,023.5 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   853.3 ns |  74.80 ns |  4.10 ns |   849.9 ns |   857.9 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,367.4 ns | 330.92 ns | 18.14 ns | 1,355.4 ns | 1,388.3 ns | 0.1907 | 0.0019 |    3208 B |
