```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **758.7 ns** |   **249.5 ns** |  **13.68 ns** |   **746.9 ns** |   **773.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   726.4 ns |   443.5 ns |  24.31 ns |   703.6 ns |   752.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   716.0 ns |   229.8 ns |  12.60 ns |   701.8 ns |   725.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   737.8 ns |   251.6 ns |  13.79 ns |   721.9 ns |   746.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   732.4 ns |   375.3 ns |  20.57 ns |   709.9 ns |   750.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,275.6 ns** |   **583.8 ns** |  **32.00 ns** | **2,242.8 ns** | **2,306.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,216.8 ns | 2,617.9 ns | 143.50 ns | 2,060.3 ns | 2,342.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,131.6 ns | 1,475.2 ns |  80.86 ns | 2,045.8 ns | 2,206.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,150.9 ns | 1,766.1 ns |  96.80 ns | 2,071.1 ns | 2,258.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,191.2 ns | 1,502.1 ns |  82.34 ns | 2,096.2 ns | 2,238.8 ns | 0.0343 | 0.0305 |   3.07 KB |
