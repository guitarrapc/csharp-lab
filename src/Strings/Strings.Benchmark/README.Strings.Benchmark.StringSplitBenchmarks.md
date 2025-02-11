```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   840.9 ns |  73.51 ns |  4.03 ns |   838.2 ns |   845.5 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,548.5 ns | 414.98 ns | 22.75 ns | 1,533.7 ns | 1,574.7 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   851.1 ns |  11.71 ns |  0.64 ns |   850.4 ns |   851.6 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,453.3 ns | 427.06 ns | 23.41 ns | 1,429.1 ns | 1,475.8 ns | 0.1907 | 0.0019 |    3208 B |
