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
| **AllocateStringStatic** | **1**      |   **736.4 ns** |   **499.9 ns** |  **27.40 ns** |   **711.3 ns** |   **765.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   715.4 ns |   232.8 ns |  12.76 ns |   707.1 ns |   730.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   700.0 ns |   277.0 ns |  15.18 ns |   689.7 ns |   717.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   734.1 ns |   479.5 ns |  26.28 ns |   709.9 ns |   762.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   722.8 ns |   544.4 ns |  29.84 ns |   693.2 ns |   752.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,551.5 ns** | **3,112.6 ns** | **170.61 ns** | **7,381.9 ns** | **7,723.1 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,022.0 ns | 5,429.6 ns | 297.62 ns | 6,837.8 ns | 7,365.3 ns | 0.1221 | 0.1068 |  10.23 KB |
| AllocateLoH          | 10     | 7,239.9 ns | 2,935.5 ns | 160.91 ns | 7,072.9 ns | 7,393.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,496.9 ns | 3,675.5 ns | 201.47 ns | 7,314.9 ns | 7,713.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,306.3 ns | 5,366.5 ns | 294.16 ns | 6,978.9 ns | 7,548.4 ns | 0.1221 | 0.1144 |  10.23 KB |
