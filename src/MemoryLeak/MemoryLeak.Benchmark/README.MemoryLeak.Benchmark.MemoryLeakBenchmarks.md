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
| **AllocateStringStatic** | **1**      |   **738.0 ns** |   **510.9 ns** |  **28.00 ns** |   **717.0 ns** |   **769.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   747.5 ns |   366.5 ns |  20.09 ns |   730.5 ns |   769.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   703.3 ns |   396.8 ns |  21.75 ns |   685.9 ns |   727.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   740.0 ns |   592.1 ns |  32.46 ns |   703.2 ns |   764.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   734.0 ns |   478.0 ns |  26.20 ns |   715.1 ns |   763.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,620.6 ns** | **2,407.1 ns** | **131.94 ns** | **7,470.9 ns** | **7,720.1 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,453.7 ns | 7,144.6 ns | 391.62 ns | 7,004.4 ns | 7,722.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,259.0 ns | 2,663.8 ns | 146.01 ns | 7,096.9 ns | 7,380.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,373.6 ns | 1,425.4 ns |  78.13 ns | 7,324.5 ns | 7,463.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,144.9 ns | 6,069.7 ns | 332.70 ns | 6,774.3 ns | 7,418.0 ns | 0.1221 | 0.1144 |  10.23 KB |
