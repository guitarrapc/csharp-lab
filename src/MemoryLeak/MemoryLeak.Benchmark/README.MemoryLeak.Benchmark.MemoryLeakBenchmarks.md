```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **789.8 ns** |   **303.7 ns** | **16.65 ns** |   **771.7 ns** |   **804.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   749.4 ns |   551.0 ns | 30.20 ns |   719.6 ns |   780.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   752.3 ns |   213.5 ns | 11.70 ns |   738.9 ns |   760.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   760.8 ns |   215.4 ns | 11.81 ns |   747.2 ns |   768.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   742.0 ns |   776.4 ns | 42.56 ns |   708.2 ns |   789.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,282.7 ns** | **1,415.7 ns** | **77.60 ns** | **2,229.8 ns** | **2,371.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,166.9 ns |   586.7 ns | 32.16 ns | 2,131.9 ns | 2,195.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,171.5 ns |   583.9 ns | 32.01 ns | 2,135.3 ns | 2,196.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,332.3 ns |   231.1 ns | 12.67 ns | 2,318.3 ns | 2,342.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,167.1 ns | 1,484.9 ns | 81.39 ns | 2,075.7 ns | 2,231.9 ns | 0.0343 | 0.0305 |   3.07 KB |
