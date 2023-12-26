```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **722.5 ns** |   **616.64 ns** |  **33.80 ns** |   **702.6 ns** |   **761.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   703.3 ns |   178.21 ns |   9.77 ns |   692.1 ns |   709.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   682.0 ns |   217.14 ns |  11.90 ns |   671.9 ns |   695.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   729.3 ns |    69.85 ns |   3.83 ns |   725.3 ns |   732.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   707.0 ns |   282.89 ns |  15.51 ns |   693.8 ns |   724.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,491.7 ns** | **3,161.85 ns** | **173.31 ns** | **7,332.7 ns** | **7,676.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,142.9 ns | 3,533.55 ns | 193.69 ns | 6,938.2 ns | 7,323.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 6,963.8 ns | 3,421.39 ns | 187.54 ns | 6,783.7 ns | 7,158.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,207.1 ns | 3,125.54 ns | 171.32 ns | 7,011.6 ns | 7,330.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,176.3 ns | 2,063.50 ns | 113.11 ns | 7,065.0 ns | 7,291.2 ns | 0.1221 | 0.1144 |  10.23 KB |
