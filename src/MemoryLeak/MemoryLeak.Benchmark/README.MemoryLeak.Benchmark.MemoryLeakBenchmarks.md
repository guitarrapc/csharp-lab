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
| **AllocateStringStatic** | **1**      |   **762.4 ns** |   **370.2 ns** |  **20.29 ns** |   **741.2 ns** |   **781.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   754.0 ns |   628.4 ns |  34.44 ns |   717.3 ns |   785.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   707.8 ns |   314.3 ns |  17.23 ns |   688.9 ns |   722.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   770.4 ns |   235.4 ns |  12.90 ns |   755.6 ns |   779.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   728.7 ns |   482.5 ns |  26.45 ns |   698.4 ns |   746.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,764.7 ns** | **2,829.5 ns** | **155.09 ns** | **7,607.6 ns** | **7,917.7 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,205.2 ns | 7,778.1 ns | 426.34 ns | 6,755.9 ns | 7,604.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,320.4 ns | 2,579.2 ns | 141.38 ns | 7,225.9 ns | 7,482.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,687.7 ns |   629.1 ns |  34.48 ns | 7,657.8 ns | 7,725.4 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,445.2 ns | 2,131.7 ns | 116.85 ns | 7,330.3 ns | 7,563.9 ns | 0.1221 | 0.1144 |  10.23 KB |
