```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **757.6 ns** |   **141.6 ns** |   **7.76 ns** |   **749.1 ns** |   **764.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   771.2 ns |   427.4 ns |  23.43 ns |   752.4 ns |   797.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   732.3 ns |   107.6 ns |   5.90 ns |   725.5 ns |   736.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   750.0 ns |   276.0 ns |  15.13 ns |   735.0 ns |   765.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   716.9 ns |   497.6 ns |  27.28 ns |   696.6 ns |   747.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,780.4 ns** | **5,528.3 ns** | **303.02 ns** | **7,493.9 ns** | **8,097.7 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,300.4 ns | 4,623.0 ns | 253.40 ns | 7,019.8 ns | 7,512.6 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,206.3 ns | 1,124.5 ns |  61.64 ns | 7,140.0 ns | 7,261.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,219.1 ns | 2,335.1 ns | 127.99 ns | 7,106.6 ns | 7,358.4 ns | 0.1297 | 0.1221 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,400.2 ns | 2,678.0 ns | 146.79 ns | 7,310.6 ns | 7,569.6 ns | 0.1221 | 0.1144 |  10.23 KB |
