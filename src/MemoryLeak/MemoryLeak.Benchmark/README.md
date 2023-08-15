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
|        **RentReturn** |      **1** |    **45.22 ns** |  **0.468 ns** | **0.026 ns** |    **45.19 ns** |    **45.24 ns** |         **-** |
| AllocateArrayPool |      1 |   187.36 ns |  2.203 ns | 0.121 ns |   187.29 ns |   187.50 ns |         - |
|        **RentReturn** |     **10** |   **880.77 ns** |  **9.812 ns** | **0.538 ns** |   **880.15 ns** |   **881.11 ns** |         **-** |
| AllocateArrayPool |     10 | 1,334.78 ns | 33.786 ns | 1.852 ns | 1,333.67 ns | 1,336.91 ns |         - |
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
|               Method | Number |        Mean |       Error |      StdDev |        Min |         Max |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|--------------------- |------- |------------:|------------:|------------:|-----------:|------------:|-------:|-------:|-------:|----------:|
| **AllocateStringStatic** |      **1** |  **1,060.1 ns** |    **483.3 ns** |    **26.49 ns** | **1,039.2 ns** |  **1,089.9 ns** | **0.0553** | **0.0534** |      **-** |      **1 KB** |
|       AllocateString |      1 |    944.9 ns |    510.1 ns |    27.96 ns |   922.1 ns |    976.1 ns | 0.0553 | 0.0534 |      - |      1 KB |
|          AllocateLoH |      1 |    908.3 ns |    865.5 ns |    47.44 ns |   879.7 ns |    963.1 ns | 0.0553 | 0.0534 |      - |      1 KB |
|        AllocateArray |      1 |    900.9 ns |    295.9 ns |    16.22 ns |   885.4 ns |    917.7 ns | 0.0553 | 0.0534 |      - |      1 KB |
|    AllocateArrayPool |      1 |    898.5 ns |    388.0 ns |    21.27 ns |   883.0 ns |    922.8 ns | 0.0553 | 0.0534 |      - |      1 KB |
| **AllocateStringStatic** |     **10** | **10,453.5 ns** | **23,755.7 ns** | **1,302.13 ns** | **9,376.7 ns** | **11,900.7 ns** | **0.5646** | **0.5493** | **0.0153** |     **10 KB** |
|       AllocateString |     10 |  9,149.7 ns |  7,770.3 ns |   425.92 ns | 8,897.1 ns |  9,641.5 ns | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|          AllocateLoH |     10 |  8,662.3 ns |  2,041.1 ns |   111.88 ns | 8,537.4 ns |  8,753.4 ns | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|        AllocateArray |     10 |  9,155.0 ns |  5,900.8 ns |   323.44 ns | 8,782.3 ns |  9,362.5 ns | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|    AllocateArrayPool |     10 |  9,360.4 ns |  9,215.8 ns |   505.15 ns | 8,799.4 ns |  9,779.3 ns | 0.5646 | 0.5493 | 0.0153 |     10 KB |
