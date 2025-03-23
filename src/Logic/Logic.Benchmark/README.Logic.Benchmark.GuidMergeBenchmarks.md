```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **.NET 8.0** | **(20ae(...)3588) [76]** | **32.1253 ns** | **4.0548 ns** | **0.2223 ns** | **32.1239 ns** | **31.9037 ns** | **32.3482 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (20ae(...)3588) [76] | 32.0443 ns | 2.8473 ns | 0.1561 ns | 32.0347 ns | 31.8932 ns | 32.2049 ns | 0.0048 |      80 B |
| **FastMerge** | **.NET 8.0** | **(aa0e(...)d4ed) [76]** |  **0.0006 ns** | **0.0179 ns** | **0.0010 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0017 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (aa0e(...)d4ed) [76] |  0.0024 ns | 0.0374 ns | 0.0021 ns |  0.0033 ns |  0.0000 ns |  0.0037 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(dd1c(...)9363) [76]** | **46.8999 ns** | **3.0037 ns** | **0.1646 ns** | **46.8090 ns** | **46.8009 ns** | **47.0900 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (dd1c(...)9363) [76] | 39.0406 ns | 7.3620 ns | 0.4035 ns | 39.1177 ns | 38.6041 ns | 39.4000 ns | 0.0086 |     144 B |
