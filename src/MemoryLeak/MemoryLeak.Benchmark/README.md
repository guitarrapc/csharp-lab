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
| **AllocateStringStatic** |      **1** |   **740.7 ns** |   **149.5 ns** |   **8.20 ns** |   **732.3 ns** |   **748.7 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   713.6 ns |   302.0 ns |  16.56 ns |   694.4 ns |   723.6 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   700.2 ns |   346.0 ns |  18.96 ns |   680.2 ns |   717.9 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   731.1 ns |   395.2 ns |  21.66 ns |   706.5 ns |   747.1 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   721.7 ns |   222.5 ns |  12.20 ns |   708.8 ns |   733.1 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,454.3 ns** | **1,881.2 ns** | **103.12 ns** | **7,335.8 ns** | **7,523.5 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,138.3 ns | 1,324.8 ns |  72.62 ns | 7,062.4 ns | 7,207.1 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,025.5 ns | 5,336.8 ns | 292.53 ns | 6,689.1 ns | 7,219.6 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,424.2 ns | 1,522.3 ns |  83.44 ns | 7,375.8 ns | 7,520.5 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,340.3 ns | 4,461.2 ns | 244.53 ns | 7,067.9 ns | 7,540.7 ns | 0.1221 | 0.1144 |     10 KB |
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
|        **RentReturn** |      **1** |  **34.44 ns** |  **1.204 ns** | **0.066 ns** |  **34.40 ns** |  **34.52 ns** |         **-** |
| AllocateArrayPool |      1 |  99.67 ns |  1.905 ns | 0.104 ns |  99.61 ns |  99.79 ns |         - |
|        **RentReturn** |     **10** | **525.89 ns** | **33.819 ns** | **1.854 ns** | **523.75 ns** | **527.05 ns** |         **-** |
| AllocateArrayPool |     10 | 706.84 ns | 52.333 ns | 2.869 ns | 703.98 ns | 709.71 ns |         - |
