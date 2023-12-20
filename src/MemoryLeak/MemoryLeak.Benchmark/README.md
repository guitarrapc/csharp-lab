# MemoryLeak.Benchmark.MemoryLeakBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method | Number |       Mean |      Error |    StdDev |        Min |        Max |  Gen 0 |  Gen 1 | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** |      **1** |   **760.9 ns** |   **188.9 ns** |  **10.35 ns** |   **749.2 ns** |   **769.1 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   719.3 ns |   133.2 ns |   7.30 ns |   712.3 ns |   726.9 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   721.1 ns |   374.8 ns |  20.54 ns |   699.6 ns |   740.5 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   740.3 ns |   306.8 ns |  16.82 ns |   725.1 ns |   758.3 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   706.9 ns |   537.6 ns |  29.47 ns |   684.2 ns |   740.2 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,557.7 ns** | **2,787.2 ns** | **152.78 ns** | **7,404.2 ns** | **7,709.7 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,199.3 ns | 4,872.0 ns | 267.05 ns | 6,894.4 ns | 7,391.8 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,174.9 ns |   768.1 ns |  42.10 ns | 7,141.7 ns | 7,222.2 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,445.5 ns | 2,445.7 ns | 134.06 ns | 7,296.7 ns | 7,556.9 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,276.4 ns | 2,094.1 ns | 114.79 ns | 7,193.0 ns | 7,407.4 ns | 0.1221 | 0.1144 |     10 KB |
# MemoryLeak.Benchmark.NoAllocMemoryLeakBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method | Number |      Mean |      Error |   StdDev |       Min |       Max | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
|        **RentReturn** |      **1** |  **34.32 ns** |   **0.873 ns** | **0.048 ns** |  **34.29 ns** |  **34.38 ns** |         **-** |
| AllocateArrayPool |      1 |  99.97 ns |   2.934 ns | 0.161 ns |  99.86 ns | 100.16 ns |         - |
|        **RentReturn** |     **10** | **521.97 ns** |  **20.578 ns** | **1.128 ns** | **521.27 ns** | **523.27 ns** |         **-** |
| AllocateArrayPool |     10 | 715.10 ns | 134.128 ns | 7.352 ns | 706.63 ns | 719.80 ns |         - |
