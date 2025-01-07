```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **(0c18(...)3499) [76]** |  **0.0024 ns** | **0.0425 ns** | **0.0023 ns** |  **0.0000 ns** |  **0.0047 ns** |      **-** |         **-** |
| **FairMerge** | **(758e(...)ff8d) [76]** | **38.9608 ns** | **8.3403 ns** | **0.4572 ns** | **38.4718 ns** | **39.3775 ns** | **0.0086** |     **144 B** |
| **SlowMerge** | **(7ae3(...)11ce) [76]** | **32.0149 ns** | **9.5598 ns** | **0.5240 ns** | **31.7065 ns** | **32.6199 ns** | **0.0048** |      **80 B** |
