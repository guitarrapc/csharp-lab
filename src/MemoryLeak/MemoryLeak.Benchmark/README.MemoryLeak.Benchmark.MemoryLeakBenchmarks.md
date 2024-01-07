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
| **AllocateStringStatic** | **1**      |   **726.0 ns** |   **442.8 ns** |  **24.27 ns** |   **708.7 ns** |   **753.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   702.7 ns |   210.0 ns |  11.51 ns |   692.4 ns |   715.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   691.4 ns |   360.1 ns |  19.74 ns |   673.1 ns |   712.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   742.6 ns |   169.9 ns |   9.31 ns |   733.1 ns |   751.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   712.8 ns |   360.0 ns |  19.73 ns |   690.8 ns |   728.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,513.4 ns** | **2,352.7 ns** | **128.96 ns** | **7,364.5 ns** | **7,589.1 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,180.0 ns | 3,395.4 ns | 186.11 ns | 6,975.0 ns | 7,338.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 6,935.2 ns | 2,602.6 ns | 142.66 ns | 6,801.9 ns | 7,085.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,279.1 ns | 3,199.9 ns | 175.40 ns | 7,094.0 ns | 7,442.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,306.7 ns | 1,172.0 ns |  64.24 ns | 7,235.0 ns | 7,359.0 ns | 0.1221 | 0.1144 |  10.23 KB |
