```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **751.8 ns** |   **237.7 ns** | **13.03 ns** |   **738.0 ns** |   **763.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   730.5 ns |   557.9 ns | 30.58 ns |   695.2 ns |   748.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   708.2 ns |   291.8 ns | 15.99 ns |   689.8 ns |   718.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   726.4 ns |   418.8 ns | 22.96 ns |   700.3 ns |   743.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   753.4 ns |   314.8 ns | 17.25 ns |   737.1 ns |   771.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,297.7 ns** |   **967.5 ns** | **53.03 ns** | **2,244.9 ns** | **2,351.0 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,117.6 ns |   946.0 ns | 51.86 ns | 2,057.8 ns | 2,150.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,048.8 ns | 1,195.6 ns | 65.54 ns | 1,983.7 ns | 2,114.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,190.4 ns |   528.4 ns | 28.96 ns | 2,157.6 ns | 2,212.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,099.9 ns |   980.1 ns | 53.72 ns | 2,037.9 ns | 2,133.4 ns | 0.0343 | 0.0305 |   3.07 KB |
