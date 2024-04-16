```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **784.8 ns** |   **311.6 ns** |  **17.08 ns** |   **771.2 ns** |   **804.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   736.6 ns |   377.7 ns |  20.70 ns |   720.2 ns |   759.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   751.7 ns |   285.4 ns |  15.64 ns |   739.9 ns |   769.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   753.8 ns |   693.7 ns |  38.02 ns |   726.6 ns |   797.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   766.2 ns |   505.6 ns |  27.72 ns |   740.3 ns |   795.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,286.1 ns** |   **698.6 ns** |  **38.29 ns** | **2,244.1 ns** | **2,319.1 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,186.7 ns | 1,259.7 ns |  69.05 ns | 2,112.7 ns | 2,249.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,178.8 ns | 1,348.6 ns |  73.92 ns | 2,097.0 ns | 2,240.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,221.8 ns | 1,892.8 ns | 103.75 ns | 2,139.1 ns | 2,338.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,182.8 ns | 1,424.1 ns |  78.06 ns | 2,123.3 ns | 2,271.2 ns | 0.0343 | 0.0305 |   3.07 KB |
