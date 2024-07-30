```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **762.4 ns** |    **95.15 ns** |  **5.22 ns** |   **756.4 ns** |   **766.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   719.5 ns |   483.61 ns | 26.51 ns |   691.0 ns |   743.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   689.6 ns |   457.10 ns | 25.06 ns |   673.1 ns |   718.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   726.5 ns |   262.87 ns | 14.41 ns |   710.0 ns |   736.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   724.9 ns |   537.78 ns | 29.48 ns |   692.6 ns |   750.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,257.5 ns** |   **717.06 ns** | **39.30 ns** | **2,216.4 ns** | **2,294.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,164.5 ns | 1,136.42 ns | 62.29 ns | 2,094.8 ns | 2,214.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,128.1 ns | 1,641.93 ns | 90.00 ns | 2,024.7 ns | 2,188.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,178.7 ns |   498.45 ns | 27.32 ns | 2,161.9 ns | 2,210.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,181.3 ns |   198.31 ns | 10.87 ns | 2,169.0 ns | 2,189.4 ns | 0.0343 | 0.0305 |   3.07 KB |
