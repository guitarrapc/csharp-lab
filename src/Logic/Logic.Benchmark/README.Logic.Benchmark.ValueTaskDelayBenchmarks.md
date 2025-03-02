```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|--------------- |--------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| TaskDelay      | .NET 8.0 | 1      | 10.21 ms | 0.633 ms | 0.035 ms | 10.18 ms | 10.25 ms |     352 B |
| ValueTaskDelay | .NET 8.0 | 1      | 10.15 ms | 0.024 ms | 0.001 ms | 10.15 ms | 10.15 ms |     128 B |
| TaskDelay      | .NET 9.0 | 1      | 10.21 ms | 0.382 ms | 0.021 ms | 10.19 ms | 10.23 ms |     352 B |
| ValueTaskDelay | .NET 9.0 | 1      | 10.14 ms | 0.062 ms | 0.003 ms | 10.14 ms | 10.14 ms |     128 B |
