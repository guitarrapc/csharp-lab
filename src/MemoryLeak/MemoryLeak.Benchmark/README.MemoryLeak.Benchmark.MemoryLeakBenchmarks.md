```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **744.2 ns** |   **557.62 ns** | **30.57 ns** |   **709.6 ns** |   **767.3 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   736.4 ns |   360.79 ns | 19.78 ns |   713.6 ns |   749.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   713.8 ns |    49.29 ns |  2.70 ns |   711.3 ns |   716.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   715.0 ns |   428.27 ns | 23.47 ns |   699.1 ns |   742.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   713.1 ns |   183.49 ns | 10.06 ns |   701.5 ns |   719.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,176.4 ns** | **1,715.88 ns** | **94.05 ns** | **2,105.6 ns** | **2,283.1 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,178.7 ns | 1,326.20 ns | 72.69 ns | 2,111.3 ns | 2,255.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,106.2 ns | 1,680.97 ns | 92.14 ns | 2,000.2 ns | 2,167.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,218.6 ns |   821.98 ns | 45.06 ns | 2,169.4 ns | 2,257.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,110.6 ns | 1,248.74 ns | 68.45 ns | 2,032.7 ns | 2,161.1 ns | 0.0343 | 0.0305 |   3.07 KB |
