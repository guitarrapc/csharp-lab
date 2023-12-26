```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean           | Error         | StdDev      | Min            | Max            | Gen0    | Allocated |
|------------------- |------- |---------------:|--------------:|------------:|---------------:|---------------:|--------:|----------:|
| **StringSplitNoAlloc** | **1**      |       **799.2 ns** |      **18.78 ns** |     **1.03 ns** |       **798.2 ns** |       **800.2 ns** |       **-** |         **-** |
| StringSplit        | 1      |     1,507.0 ns |      50.95 ns |     2.79 ns |     1,503.8 ns |     1,509.1 ns |  0.0381 |    3208 B |
| **StringSplitNoAlloc** | **10**     |     **8,034.3 ns** |      **90.84 ns** |     **4.98 ns** |     **8,028.9 ns** |     **8,038.7 ns** |       **-** |         **-** |
| StringSplit        | 10     |    15,147.3 ns |     932.08 ns |    51.09 ns |    15,089.4 ns |    15,186.2 ns |  0.3815 |   32080 B |
| **StringSplitNoAlloc** | **100**    |    **80,421.8 ns** |   **1,819.27 ns** |    **99.72 ns** |    **80,313.6 ns** |    **80,510.0 ns** |       **-** |         **-** |
| StringSplit        | 100    |   146,739.3 ns |   2,529.61 ns |   138.66 ns |   146,636.6 ns |   146,897.0 ns |  3.6621 |  320800 B |
| **StringSplitNoAlloc** | **1000**   |   **800,619.7 ns** |  **12,132.69 ns** |   **665.03 ns** |   **800,156.7 ns** |   **801,381.8 ns** |       **-** |       **1 B** |
| StringSplit        | 1000   | 1,533,663.7 ns | 103,996.45 ns | 5,700.40 ns | 1,527,097.0 ns | 1,537,338.7 ns | 37.1094 | 3208001 B |
