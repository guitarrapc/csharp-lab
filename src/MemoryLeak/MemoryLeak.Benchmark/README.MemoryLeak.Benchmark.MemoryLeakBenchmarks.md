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
| **AllocateStringStatic** | **1**      |   **704.7 ns** |   **524.1 ns** |  **28.73 ns** |   **685.8 ns** |   **737.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   698.1 ns |   175.3 ns |   9.61 ns |   687.5 ns |   706.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   683.6 ns |   382.8 ns |  20.98 ns |   661.7 ns |   703.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   693.8 ns |   292.5 ns |  16.03 ns |   678.1 ns |   710.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   670.8 ns |   285.3 ns |  15.64 ns |   658.6 ns |   688.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,298.3 ns** |   **544.4 ns** |  **29.84 ns** | **7,277.2 ns** | **7,332.5 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 6,754.3 ns | 1,187.7 ns |  65.10 ns | 6,697.7 ns | 6,825.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 6,696.8 ns | 2,292.9 ns | 125.68 ns | 6,557.6 ns | 6,801.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 6,999.1 ns | 1,349.0 ns |  73.95 ns | 6,928.8 ns | 7,076.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 6,912.8 ns | 2,757.0 ns | 151.12 ns | 6,740.4 ns | 7,022.2 ns | 0.1221 | 0.1144 |  10.23 KB |
