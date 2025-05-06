```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|--------------- |--------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| TaskDelay      | .NET 8.0 | 1      | 10.28 ms | 0.494 ms | 0.027 ms | 10.25 ms | 10.30 ms |     352 B |
| ValueTaskDelay | .NET 8.0 | 1      | 10.16 ms | 0.149 ms | 0.008 ms | 10.15 ms | 10.16 ms |     128 B |
| TaskDelay      | .NET 9.0 | 1      | 10.22 ms | 0.387 ms | 0.021 ms | 10.21 ms | 10.24 ms |     348 B |
| ValueTaskDelay | .NET 9.0 | 1      | 10.16 ms | 0.063 ms | 0.003 ms | 10.16 ms | 10.16 ms |     128 B |
