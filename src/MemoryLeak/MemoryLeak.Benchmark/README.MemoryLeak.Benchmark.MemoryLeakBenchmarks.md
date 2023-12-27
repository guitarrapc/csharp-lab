```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **758.8 ns** |   **142.0 ns** |   **7.79 ns** |   **751.2 ns** |   **766.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   716.2 ns |   354.9 ns |  19.45 ns |   701.4 ns |   738.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   725.7 ns |   432.9 ns |  23.73 ns |   703.6 ns |   750.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   711.8 ns |   455.3 ns |  24.96 ns |   687.0 ns |   736.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   716.7 ns |   702.6 ns |  38.51 ns |   680.6 ns |   757.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,554.7 ns** | **4,324.0 ns** | **237.01 ns** | **7,327.4 ns** | **7,800.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,197.6 ns | 3,089.3 ns | 169.33 ns | 7,007.2 ns | 7,331.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,158.6 ns | 1,475.5 ns |  80.88 ns | 7,069.2 ns | 7,226.6 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,503.9 ns |   928.7 ns |  50.90 ns | 7,451.8 ns | 7,553.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,219.7 ns | 1,962.6 ns | 107.57 ns | 7,154.2 ns | 7,343.8 ns | 0.1221 | 0.1144 |  10.23 KB |
