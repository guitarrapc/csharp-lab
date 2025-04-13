```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   848.0 ns |  49.54 ns |  2.72 ns |   844.9 ns |   849.8 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,464.3 ns | 238.22 ns | 13.06 ns | 1,449.7 ns | 1,474.8 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   849.3 ns |  10.19 ns |  0.56 ns |   848.8 ns |   849.9 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,354.8 ns | 222.39 ns | 12.19 ns | 1,342.9 ns | 1,367.2 ns | 0.1907 | 0.0019 |    3208 B |
