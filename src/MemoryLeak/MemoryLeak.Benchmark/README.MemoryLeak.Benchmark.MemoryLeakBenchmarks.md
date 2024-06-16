```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **757.0 ns** |   **195.5 ns** | **10.72 ns** |   **746.4 ns** |   **767.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   721.8 ns |   133.6 ns |  7.32 ns |   713.5 ns |   727.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   727.2 ns |   222.5 ns | 12.20 ns |   713.1 ns |   734.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   739.6 ns |   848.7 ns | 46.52 ns |   711.3 ns |   793.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   751.8 ns |   361.2 ns | 19.80 ns |   735.6 ns |   773.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,214.8 ns** | **1,389.7 ns** | **76.17 ns** | **2,162.3 ns** | **2,302.1 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,123.9 ns | 1,649.7 ns | 90.42 ns | 2,068.6 ns | 2,228.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,118.9 ns |   289.1 ns | 15.85 ns | 2,105.6 ns | 2,136.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,182.6 ns |   881.5 ns | 48.32 ns | 2,126.8 ns | 2,211.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,130.6 ns | 1,129.0 ns | 61.89 ns | 2,080.8 ns | 2,199.9 ns | 0.0343 | 0.0305 |   3.07 KB |
