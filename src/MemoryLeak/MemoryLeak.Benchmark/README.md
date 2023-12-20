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
| **AllocateStringStatic** |      **1** |   **738.9 ns** |   **123.1 ns** |   **6.74 ns** |   **731.4 ns** |   **744.5 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   689.5 ns |   156.4 ns |   8.57 ns |   681.8 ns |   698.7 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   702.4 ns |   222.2 ns |  12.18 ns |   690.0 ns |   714.4 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   731.7 ns |   308.0 ns |  16.88 ns |   712.3 ns |   742.6 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   688.2 ns |   655.7 ns |  35.94 ns |   666.0 ns |   729.6 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,573.3 ns** | **2,699.7 ns** | **147.98 ns** | **7,455.1 ns** | **7,739.3 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,219.5 ns | 1,343.0 ns |  73.62 ns | 7,167.3 ns | 7,303.7 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,152.8 ns | 6,666.5 ns | 365.41 ns | 6,771.1 ns | 7,499.4 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,303.7 ns | 4,133.6 ns | 226.57 ns | 7,087.0 ns | 7,539.0 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,033.2 ns | 5,064.9 ns | 277.63 ns | 6,727.4 ns | 7,269.4 ns | 0.1221 | 0.1144 |     10 KB |
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
|            Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
|        **RentReturn** |      **1** |  **35.71 ns** |  **4.756 ns** | **0.261 ns** |  **35.41 ns** |  **35.90 ns** |         **-** |
| AllocateArrayPool |      1 | 103.27 ns | 37.832 ns | 2.074 ns | 100.87 ns | 104.51 ns |         - |
|        **RentReturn** |     **10** | **556.20 ns** | **20.215 ns** | **1.108 ns** | **555.55 ns** | **557.48 ns** |         **-** |
| AllocateArrayPool |     10 | 701.31 ns |  9.487 ns | 0.520 ns | 700.76 ns | 701.80 ns |         - |
