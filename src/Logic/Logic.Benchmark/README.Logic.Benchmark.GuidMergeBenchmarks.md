```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(5d4f(...)927a) [76]** | **47.3493 ns** | **4.6408 ns** | **0.2544 ns** | **47.1732 ns** | **47.6409 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(f13b(...)dd76) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| **SlowMerge** | **(feca(...)5197) [76]** | **33.8800 ns** | **3.6990 ns** | **0.2028 ns** | **33.7196 ns** | **34.1079 ns** | **0.0010** |      **80 B** |
