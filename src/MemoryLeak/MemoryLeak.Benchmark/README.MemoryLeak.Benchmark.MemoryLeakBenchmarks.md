```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **793.5 ns** |   **332.59 ns** | **18.23 ns** |   **776.4 ns** |   **812.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   766.4 ns |   515.14 ns | 28.24 ns |   740.2 ns |   796.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   728.8 ns |   483.27 ns | 26.49 ns |   711.1 ns |   759.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   732.9 ns |    73.07 ns |  4.01 ns |   728.3 ns |   735.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   763.4 ns |   396.73 ns | 21.75 ns |   738.3 ns |   777.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,242.8 ns** |   **482.56 ns** | **26.45 ns** | **2,227.4 ns** | **2,273.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,195.7 ns | 1,197.25 ns | 65.63 ns | 2,127.3 ns | 2,258.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,068.8 ns |   998.40 ns | 54.73 ns | 2,028.2 ns | 2,131.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,182.5 ns |   767.80 ns | 42.09 ns | 2,143.7 ns | 2,227.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,145.8 ns | 1,256.66 ns | 68.88 ns | 2,068.1 ns | 2,199.5 ns | 0.0343 | 0.0305 |   3.07 KB |
