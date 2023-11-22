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
| **AllocateStringStatic** |      **1** |   **762.7 ns** |   **236.9 ns** |  **12.99 ns** |   **754.9 ns** |   **777.7 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   725.3 ns |   292.3 ns |  16.02 ns |   711.9 ns |   743.0 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   736.1 ns |   472.3 ns |  25.89 ns |   710.4 ns |   762.2 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   737.1 ns |   228.8 ns |  12.54 ns |   724.2 ns |   749.3 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   736.3 ns |   599.4 ns |  32.86 ns |   706.1 ns |   771.3 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,649.7 ns** |   **824.0 ns** |  **45.16 ns** | **7,606.4 ns** | **7,696.6 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,437.8 ns | 2,441.1 ns | 133.80 ns | 7,314.1 ns | 7,579.8 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,294.1 ns |   364.6 ns |  19.98 ns | 7,273.1 ns | 7,312.9 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,553.0 ns |   847.3 ns |  46.45 ns | 7,512.5 ns | 7,603.7 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,700.3 ns | 2,084.0 ns | 114.23 ns | 7,568.6 ns | 7,772.5 ns | 0.1221 | 0.1144 |     10 KB |
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
|            Method | Number |      Mean |      Error |   StdDev |       Min |       Max | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
|        **RentReturn** |      **1** |  **38.70 ns** |  **14.963 ns** | **0.820 ns** |  **38.09 ns** |  **39.64 ns** |         **-** |
| AllocateArrayPool |      1 |  98.69 ns |   1.176 ns | 0.064 ns |  98.62 ns |  98.75 ns |         - |
|        **RentReturn** |     **10** | **551.86 ns** | **146.565 ns** | **8.034 ns** | **546.48 ns** | **561.09 ns** |         **-** |
| AllocateArrayPool |     10 | 718.09 ns |  29.113 ns | 1.596 ns | 716.86 ns | 719.90 ns |         - |
