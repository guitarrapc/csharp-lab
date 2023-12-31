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
| **AllocateStringStatic** | **1**      |   **779.7 ns** |    **78.04 ns** |   **4.28 ns** |   **776.9 ns** |   **784.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   731.6 ns |   533.04 ns |  29.22 ns |   706.0 ns |   763.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   713.3 ns |   346.65 ns |  19.00 ns |   701.3 ns |   735.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   727.1 ns |   574.37 ns |  31.48 ns |   704.5 ns |   763.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   718.5 ns |   743.60 ns |  40.76 ns |   677.4 ns |   758.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,614.1 ns** | **4,408.10 ns** | **241.62 ns** | **7,411.1 ns** | **7,881.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,144.1 ns | 2,522.49 ns | 138.27 ns | 6,987.0 ns | 7,247.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,152.6 ns | 5,449.98 ns | 298.73 ns | 6,812.6 ns | 7,373.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,294.9 ns | 1,656.15 ns |  90.78 ns | 7,212.3 ns | 7,392.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,397.2 ns | 2,392.07 ns | 131.12 ns | 7,284.6 ns | 7,541.2 ns | 0.1221 | 0.1144 |  10.23 KB |
