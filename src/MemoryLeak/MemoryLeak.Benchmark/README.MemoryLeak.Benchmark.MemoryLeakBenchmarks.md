```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **758.6 ns** |   **312.88 ns** |  **17.15 ns** |   **740.4 ns** |   **774.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   758.5 ns |    96.69 ns |   5.30 ns |   753.5 ns |   764.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   740.4 ns |   178.77 ns |   9.80 ns |   729.1 ns |   746.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   751.4 ns |   755.65 ns |  41.42 ns |   703.9 ns |   779.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   730.7 ns |   934.44 ns |  51.22 ns |   674.0 ns |   773.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,270.5 ns** | **2,273.26 ns** | **124.61 ns** | **2,129.4 ns** | **2,365.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,206.3 ns | 1,010.79 ns |  55.40 ns | 2,156.3 ns | 2,265.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,169.5 ns | 2,425.07 ns | 132.93 ns | 2,028.8 ns | 2,293.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,190.7 ns | 1,574.09 ns |  86.28 ns | 2,104.5 ns | 2,277.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,215.7 ns | 2,592.83 ns | 142.12 ns | 2,064.9 ns | 2,347.1 ns | 0.0343 | 0.0305 |   3.07 KB |
