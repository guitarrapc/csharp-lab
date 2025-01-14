```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **745.8 ns** | **1,111.5 ns** |  **60.93 ns** |   **684.0 ns** |   **805.8 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   715.3 ns |   787.8 ns |  43.18 ns |   668.5 ns |   753.7 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   699.6 ns |   772.4 ns |  42.34 ns |   652.2 ns |   733.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   696.9 ns |   741.7 ns |  40.65 ns |   669.0 ns |   743.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   699.7 ns |   824.4 ns |  45.19 ns |   649.2 ns |   736.4 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,143.8 ns** | **2,273.1 ns** | **124.60 ns** | **2,064.1 ns** | **2,287.4 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,023.8 ns |   248.8 ns |  13.64 ns | 2,014.1 ns | 2,039.4 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,175.8 ns |   529.3 ns |  29.01 ns | 2,150.9 ns | 2,207.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,234.6 ns |   234.8 ns |  12.87 ns | 2,220.0 ns | 2,244.3 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,204.6 ns |   342.7 ns |  18.78 ns | 2,189.8 ns | 2,225.7 ns | 0.1869 | 0.1831 |   3.07 KB |
