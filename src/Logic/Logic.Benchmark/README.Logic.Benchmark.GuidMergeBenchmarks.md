```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(03d4(...)9392) [76]** |  **0.0016 ns** |  **0.0261 ns** | **0.0014 ns** |  **0.0020 ns** |  **0.0000 ns** |  **0.0028 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (03d4(...)9392) [76] |  0.0065 ns |  0.1209 ns | 0.0066 ns |  0.0062 ns |  0.0000 ns |  0.0132 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(beed(...)b7b6) [76]** | **49.7890 ns** |  **9.4158 ns** | **0.5161 ns** | **49.5269 ns** | **49.4564 ns** | **50.3835 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (beed(...)b7b6) [76] | 43.2518 ns | 10.1612 ns | 0.5570 ns | 43.4448 ns | 42.6240 ns | 43.6866 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(e1af(...)0fb2) [76]** | **34.2316 ns** |  **5.3495 ns** | **0.2932 ns** | **34.2577 ns** | **33.9262 ns** | **34.5109 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (e1af(...)0fb2) [76] | 33.9279 ns |  4.9742 ns | 0.2727 ns | 33.7767 ns | 33.7643 ns | 34.2426 ns | 0.0048 |      80 B |
