# MemoryLeak.Benchmark.NoAllocMemoryLeakBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method | Number |        Mean |     Error |   StdDev |         Min |         Max | Allocated |
|------------------ |------- |------------:|----------:|---------:|------------:|------------:|----------:|
|        **RentReturn** |      **1** |    **46.13 ns** |  **0.788 ns** | **0.043 ns** |    **46.10 ns** |    **46.18 ns** |         **-** |
| AllocateArrayPool |      1 |   187.76 ns |  0.330 ns | 0.018 ns |   187.75 ns |   187.78 ns |         - |
|        **RentReturn** |     **10** |   **861.29 ns** | **23.646 ns** | **1.296 ns** |   **859.79 ns** |   **862.04 ns** |         **-** |
| AllocateArrayPool |     10 | 1,337.15 ns | 50.561 ns | 2.771 ns | 1,335.38 ns | 1,340.35 ns |         - |
# MemoryLeak.Benchmark.MemoryLeakBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method | Number |        Mean |        Error |      StdDev |        Min |         Max |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|--------------------- |------- |------------:|-------------:|------------:|-----------:|------------:|-------:|-------:|-------:|----------:|
| **AllocateStringStatic** |      **1** |    **974.7 ns** |     **91.07 ns** |     **4.99 ns** |   **969.1 ns** |    **978.8 ns** | **0.0553** | **0.0534** |      **-** |      **1 KB** |
|       AllocateString |      1 |    932.7 ns |    358.01 ns |    19.62 ns |   921.0 ns |    955.3 ns | 0.0553 | 0.0534 |      - |      1 KB |
|          AllocateLoH |      1 |    875.0 ns |    651.58 ns |    35.72 ns |   838.3 ns |    909.6 ns | 0.0553 | 0.0534 |      - |      1 KB |
|        AllocateArray |      1 |    916.0 ns |    779.84 ns |    42.75 ns |   877.0 ns |    961.7 ns | 0.0553 | 0.0534 |      - |      1 KB |
|    AllocateArrayPool |      1 |    924.4 ns |    320.76 ns |    17.58 ns |   907.8 ns |    942.8 ns | 0.0553 | 0.0534 |      - |      1 KB |
| **AllocateStringStatic** |     **10** | **11,610.3 ns** | **63,563.56 ns** | **3,484.13 ns** | **9,169.9 ns** | **15,600.4 ns** | **0.5646** | **0.5493** | **0.0153** |     **10 KB** |
|       AllocateString |     10 |  9,634.4 ns | 10,770.52 ns |   590.37 ns | 9,028.3 ns | 10,207.7 ns | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|          AllocateLoH |     10 |  8,561.6 ns |  4,954.42 ns |   271.57 ns | 8,376.9 ns |  8,873.4 ns | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|        AllocateArray |     10 |  9,010.1 ns |  7,744.55 ns |   424.51 ns | 8,685.4 ns |  9,490.4 ns | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|    AllocateArrayPool |     10 |  9,131.2 ns |    747.88 ns |    40.99 ns | 9,083.8 ns |  9,155.2 ns | 0.5646 | 0.5493 | 0.0153 |     10 KB |
