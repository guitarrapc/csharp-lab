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
| **AllocateStringStatic** | **1**      |   **795.0 ns** |   **211.9 ns** |  **11.61 ns** |   **781.9 ns** |   **804.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   753.3 ns |   581.9 ns |  31.90 ns |   732.1 ns |   789.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   728.7 ns |   117.7 ns |   6.45 ns |   723.0 ns |   735.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   739.3 ns |   345.2 ns |  18.92 ns |   717.5 ns |   751.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   747.4 ns |   415.6 ns |  22.78 ns |   733.1 ns |   773.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,580.7 ns** | **2,868.1 ns** | **157.21 ns** | **7,474.3 ns** | **7,761.3 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,322.3 ns | 2,888.4 ns | 158.32 ns | 7,140.0 ns | 7,424.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,169.1 ns | 4,291.2 ns | 235.22 ns | 6,897.5 ns | 7,305.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,506.3 ns | 3,328.8 ns | 182.46 ns | 7,344.0 ns | 7,703.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,429.5 ns | 1,303.2 ns |  71.44 ns | 7,374.0 ns | 7,510.1 ns | 0.1221 | 0.1144 |  10.23 KB |
