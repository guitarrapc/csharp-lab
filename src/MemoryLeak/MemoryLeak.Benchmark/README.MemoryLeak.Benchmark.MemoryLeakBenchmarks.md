```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **749.7 ns** |   **128.0 ns** |   **7.02 ns** |   **742.0 ns** |   **755.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   738.6 ns |   407.0 ns |  22.31 ns |   712.9 ns |   752.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   752.2 ns |   425.5 ns |  23.32 ns |   725.5 ns |   768.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   765.1 ns |   462.2 ns |  25.33 ns |   736.8 ns |   785.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   772.7 ns |   180.7 ns |   9.90 ns |   761.4 ns |   779.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,670.3 ns** | **5,068.4 ns** | **277.82 ns** | **7,362.0 ns** | **7,901.3 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,609.5 ns | 4,645.9 ns | 254.65 ns | 7,317.0 ns | 7,781.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,088.1 ns | 4,498.4 ns | 246.57 ns | 6,865.1 ns | 7,352.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,663.9 ns | 6,955.8 ns | 381.27 ns | 7,229.1 ns | 7,941.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,465.0 ns | 6,460.2 ns | 354.11 ns | 7,057.4 ns | 7,697.2 ns | 0.1221 | 0.1144 |  10.23 KB |
