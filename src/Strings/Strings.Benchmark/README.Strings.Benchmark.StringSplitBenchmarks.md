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
| StringSplitNoAlloc | .NET 8.0 | 1      |   840.4 ns |  33.30 ns |  1.83 ns |   839.1 ns |   842.5 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,476.9 ns | 438.73 ns | 24.05 ns | 1,452.9 ns | 1,501.0 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   853.3 ns |  28.15 ns |  1.54 ns |   851.8 ns |   854.9 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,369.9 ns | 322.08 ns | 17.65 ns | 1,353.7 ns | 1,388.7 ns | 0.1907 | 0.0019 |    3208 B |
