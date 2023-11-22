# MemoryLeak.Benchmark.MemoryLeakBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT
  ShortRun : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method | Number |       Mean |      Error |    StdDev |        Min |        Max |  Gen 0 |  Gen 1 | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** |      **1** |   **735.6 ns** |   **518.5 ns** |  **28.42 ns** |   **719.1 ns** |   **768.4 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   727.4 ns |   592.7 ns |  32.49 ns |   692.0 ns |   755.9 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   711.8 ns |   221.2 ns |  12.12 ns |   699.7 ns |   723.9 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   726.8 ns |   386.8 ns |  21.20 ns |   707.2 ns |   749.3 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   727.5 ns |   206.7 ns |  11.33 ns |   714.4 ns |   734.1 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,596.9 ns** | **4,255.8 ns** | **233.28 ns** | **7,331.4 ns** | **7,768.8 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,296.1 ns | 3,938.4 ns | 215.88 ns | 7,101.1 ns | 7,528.1 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,189.9 ns | 5,296.9 ns | 290.34 ns | 6,854.6 ns | 7,358.9 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,410.5 ns | 3,380.7 ns | 185.31 ns | 7,215.8 ns | 7,584.7 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,417.0 ns | 4,749.3 ns | 260.32 ns | 7,127.1 ns | 7,630.7 ns | 0.1221 | 0.1144 |     10 KB |
# MemoryLeak.Benchmark.NoAllocMemoryLeakBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT
  ShortRun : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
|        **RentReturn** |      **1** |  **38.09 ns** |  **1.296 ns** | **0.071 ns** |  **38.01 ns** |  **38.15 ns** |         **-** |
| AllocateArrayPool |      1 |  98.78 ns |  2.459 ns | 0.135 ns |  98.66 ns |  98.93 ns |         - |
|        **RentReturn** |     **10** | **546.11 ns** | **43.374 ns** | **2.378 ns** | **543.70 ns** | **548.46 ns** |         **-** |
| AllocateArrayPool |     10 | 722.93 ns | 28.668 ns | 1.571 ns | 721.27 ns | 724.39 ns |         - |
