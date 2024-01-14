```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **747.5 ns** |   **306.4 ns** |  **16.79 ns** |   **732.5 ns** |   **765.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   713.6 ns |   313.4 ns |  17.18 ns |   699.6 ns |   732.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   690.6 ns |   331.3 ns |  18.16 ns |   674.0 ns |   710.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   725.7 ns |   368.7 ns |  20.21 ns |   705.6 ns |   746.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   709.5 ns |   169.4 ns |   9.29 ns |   701.0 ns |   719.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,624.5 ns** | **1,904.3 ns** | **104.38 ns** | **7,520.3 ns** | **7,729.0 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 6,980.9 ns | 2,005.4 ns | 109.92 ns | 6,904.3 ns | 7,106.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,042.1 ns |   161.4 ns |   8.85 ns | 7,034.3 ns | 7,051.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,375.2 ns | 1,482.8 ns |  81.28 ns | 7,310.6 ns | 7,466.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,342.9 ns | 2,579.2 ns | 141.38 ns | 7,184.0 ns | 7,454.8 ns | 0.1221 | 0.1144 |  10.23 KB |
